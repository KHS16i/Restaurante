using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Menaje;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Menaje
{
    class cls_Menaje_BLL
    {
        public void Listar_Filtrar_MENAJES(ref cls_Menaje_DAL obj_Menaje)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Menaje.sNombre == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_MENAJES"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Menaje.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_MENAJES"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "MENAJES";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Menaje.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Menaje.dtDatos = null;
            }
            obj_Menaje.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_MENAJES(ref cls_Menaje_DAL obj_Menaje)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Menaje.sNombre);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_MENAJES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Menaje.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_MENAJES(ref cls_Menaje_DAL obj_Menaje)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Menaje.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Apellidos", "7", obj_Menaje.sUbicacion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", obj_Menaje.sPlaca_Serie);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono_Personal", "8", obj_Menaje.dFecha_Registro);
            Obj_BD_DAL.DtParametros.Rows.Add("@Contacto_Emergencia", "1", obj_Menaje.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "1", obj_Menaje.iProveedor);
            
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_MENAJES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Menaje.sMsjError == string.Empty)
            {
                obj_Menaje.iMenaje_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_Menaje.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_MENAJES(ref cls_Menaje_DAL obj_Menaje)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Menaje.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Apellidos", "7", obj_Menaje.sUbicacion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", obj_Menaje.sPlaca_Serie);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono_Personal", "8", obj_Menaje.dFecha_Registro);
            Obj_BD_DAL.DtParametros.Rows.Add("@Contacto_Emergencia", "1", obj_Menaje.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "1", obj_Menaje.iProveedor);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_MENAJES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Menaje.sMsjError = Obj_BD_DAL.sMsjError;
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
