using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Incapacidades;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Incapacidades
{
    public class cls_Incapacidades_BLL
    {
        public void Listar_Filtrar_INCAPACIDADES(ref cls_Incapacidades_DAL obj_Incapacidades)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Incapacidades.sEmpleado_ID == "")
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_INCAPACIDADES"].ToString();
            }
            else
            {

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Incapacidades.sEmpleado_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_INCAPACIDADES"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "INCAPACIDADES";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Incapacidades.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Incapacidades.dtDatos = null;
            }
            obj_Incapacidades.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_INCAPACIDADES(ref cls_Incapacidades_DAL obj_Incapacidades)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Incapacidades.sEmpleado_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_INCAPACIDADES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Incapacidades.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_INCAPACIDADES(ref cls_Incapacidades_DAL obj_Incapacidades)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", obj_Incapacidades.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Inicio", "11", obj_Incapacidades.dFecha_Inicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Final", "11", obj_Incapacidades.dFecha_Final);
            Obj_BD_DAL.DtParametros.Rows.Add("@Numero_Orden", "1", obj_Incapacidades.iNuemro_Orden);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_Incapacidades.sDescripcion);


            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_INCAPACIDADES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Incapacidades.sMsjError == string.Empty)
            {
                obj_Incapacidades.sEmpleado_ID = Obj_BD_DAL.sValorScalar;
            }
            obj_Incapacidades.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_INCAPACIDADES(ref cls_Incapacidades_DAL obj_Incapacidades)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", obj_Incapacidades.iIncapacidad_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", obj_Incapacidades.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Inicio", "11", obj_Incapacidades.dFecha_Inicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Final", "11", obj_Incapacidades.dFecha_Final);
            Obj_BD_DAL.DtParametros.Rows.Add("@Numero_Orden", "1", obj_Incapacidades.iNuemro_Orden);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_Incapacidades.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_INCAPACIDADES"].ToString().Trim();

          
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Incapacidades.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
/*
case "1": TipoDatoSQL = SqlDbType.Int;
case "2": TipoDatoSQL = SqlDbType.Decimal;
case "3": TipoDatoSQL = SqlDbType.Float;
case "4": TipoDatoSQL = SqlDbType.Char;
case "5": TipoDatoSQL = SqlDbType.NChar;
case "6": TipoDatoSQL = SqlDbType.VarChar;
case "7": TipoDatoSQL = SqlDbType.NVarChar;
case "8": TipoDatoSQL = SqlDbType.DateTime;
case "9": TipoDatoSQL = SqlDbType.Bit;
case "10": TipoDatoSQL = SqlDbType.Money;
case "11": TipoDatoSQL = SqlDbType.Date;

*/
