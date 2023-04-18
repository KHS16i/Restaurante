using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BLL.BD
{
     public class cls_BD_BLL
    {
        public void Crear_DT_Parametros(ref cls_BD_DAL Obj_DB_DAL)
        {

            Obj_DB_DAL.DtParametros = new DataTable("PARAMETROS_SP");

            Obj_DB_DAL.DtParametros.Columns.Add("NOMBRE_PARAMETRO");
            Obj_DB_DAL.DtParametros.Columns.Add("TP_DATO_PARAMETRO");
            Obj_DB_DAL.DtParametros.Columns.Add("VALOR_PARAMETRO");
        }

        public void Exec_DataAdapter(ref cls_BD_DAL Obj_DB_DAL)
        {
            try
            {
                //CREA EL OBJETO DE CONECCION CON EL APP CONFIG
                Obj_DB_DAL.Obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["WIN_AUT"].ToString().Trim());

                //ABRIR LA CONECION Y AUTENTIFICA A LA BASE DE DATOS
                if (Obj_DB_DAL.Obj_SqlCnx.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.Obj_SqlCnx.Open();
                }

                //CREA EL DATA ADATER, DEFINIR EL NOMBRE DEL STORE PROCEDURE A EJECUTAR Y EL TIPO DE SEGURIDAD
                Obj_DB_DAL.Obj_SqlDap = new SqlDataAdapter(Obj_DB_DAL.sNomSP, Obj_DB_DAL.Obj_SqlCnx);


                Obj_DB_DAL.Obj_SqlDap.SelectCommand.CommandType = CommandType.StoredProcedure;//IMPORTANTE, evitar el inyection a la base de datos


                //AGREGA LOS PARAMETROS
                #region AGREGAR PARAMETROS

                if (Obj_DB_DAL.DtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_DB_DAL.DtParametros.Rows)
                    {
                        #region Definicion de tipo de datos en SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.Date;
                                    break;
                                }
                            case "12":
                                {
                                    TipoDatoSQL = SqlDbType.BigInt;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_DB_DAL.Obj_SqlDap.SelectCommand.Parameters.Add(dr[0].ToString(),//Nombre del parametro
                            TipoDatoSQL//el tipo de datos que entiende el SQL - resultado del switch
                            ).Value = dr[2].ToString();//el valor del parametro

                    }
                }

                #endregion


                //Limpia del DATA SET y ejecuta del DATA ADAPTER
                Obj_DB_DAL.Ds = new DataSet();

                Obj_DB_DAL.Obj_SqlDap.Fill(
                Obj_DB_DAL.Ds,//Lugar donde queda la informacion que trae el STORE PROCEDURE
                Obj_DB_DAL.sNomTabla//Nombre logico del DATA TABLE que va a caerse en el Ds
                );

                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {//sea cual sea el resultado del try catch el finally nos ayuda a corroborar si la coneccion quedo abierta por alguna razon
                if (Obj_DB_DAL.Obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_DB_DAL.Obj_SqlCnx.Close();//entonces si quedo abierta, la cerramos en esta instruccion
                }

                Obj_DB_DAL.Obj_SqlCnx.Dispose();//y aca destruimos la coneccion abierta, limpiando todo proceso abierto

            }

        }

        public void Exec_Command(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                //PASO # 1 - CREAR EL OBJTO DE CONEXIÓN CON EL APP CONFIG
                Obj_BD_DAL.Obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["WIN_AUT"].ToString().Trim());


                //PASO # 2 - ABRIR LA CONEXIÓN Y AUTENTICARME A LA BASE DE DATOS
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Open();
                }

                //PASO # 3 - CREAR EL SQL COMMAND, DEFINIIR EL NOMBRE DEL STORE PROCEDURE A EJECUTAR Y EL TIPO DE SEGURIDAD
                Obj_BD_DAL.Obj_Sql_Cmd = new SqlCommand(      //Cambia aqui
                Obj_BD_DAL.sNomSP, // NOMBRE DEL STORE PROCEDURE A EJECUTAR
                Obj_BD_DAL.Obj_SqlCnx //OBJETO SQL CONNECTION ABIERTO (PASO 2)
                );

                Obj_BD_DAL.Obj_Sql_Cmd.CommandType = CommandType.StoredProcedure; //Cambia aqui

                //PASO # 4 - AGREGAR PARAMETROS
                #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.DtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.DtParametros.Rows)
                    {
                        #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.Date;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_BD_DAL.Obj_Sql_Cmd.Parameters.Add(dr[0].ToString(), // nombre del parametro | - Cambia aqui
                       TipoDatoSQL // el tipo de datos que entiende el sql - resultado del switch
                       ).Value = dr[2].ToString(); // el valor del parametro

                    }
                }

                #endregion

                //PASO # 5 - EJECUCIÓN DEL SQL COMMAND

                //Valida si es con Entity o No

                
                    Obj_BD_DAL.Obj_Sql_Cmd.ExecuteNonQuery();
                


                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Close();
                }

                Obj_BD_DAL.Obj_SqlCnx.Dispose();
            }
        }
    }
}
