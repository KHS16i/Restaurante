using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Empleados;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Empleados
{
    public class cls_Empleados_BLL
    {
        public void Listar_Filtrar_EMPLEADOS(ref cls_Empleados_DAL obj_Empleados)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Empleados.sEmpleado_ID.Equals("") || obj_Empleados.sEmpleado_ID == null  )
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_EMPLEADOS"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Empleados.sEmpleado_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_EMPLEADOS"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "EMPLEADOS";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Empleados.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Empleados.dtDatos = null;
            }
            obj_Empleados.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_EMPLEADOS(ref cls_Empleados_DAL obj_Empleados)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_EMPLEADOS"].ToString().Trim();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Empleados.sEmpleado_ID);

            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Empleados.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_EMPLEADOS(ref cls_Empleados_DAL obj_Empleados)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_EMPLEADOS"].ToString().Trim();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", obj_Empleados.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Empleados.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Apellidos", "7", obj_Empleados.sApellidos);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", obj_Empleados.sDireccion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono_Personal", "7", obj_Empleados.sTelefono_Personal);
            Obj_BD_DAL.DtParametros.Rows.Add("@Contacto_Emergencia", "7", obj_Empleados.sContacto_Emergencia);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "7", obj_Empleados.sCorreo);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Nacimiento", "11", obj_Empleados.dFecha_Nacimiento);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Ingreso", "8", obj_Empleados.dFecha_Ingreso);
            Obj_BD_DAL.DtParametros.Rows.Add("@Puesto_ID", "1", obj_Empleados.iPuesto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Vacaciones_ID", "1", obj_Empleados.iVacaciones);
  

            

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Empleados.sMsjError == string.Empty)
            {
                obj_Empleados.sEmpleado_ID = Obj_BD_DAL.sValorScalar;
            }
            obj_Empleados.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_EMPLEADOS(ref cls_Empleados_DAL obj_Empleados)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "7", obj_Empleados.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Empleados.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Apellidos", "7", obj_Empleados.sApellidos);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", obj_Empleados.sDireccion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono_Personal", "7", obj_Empleados.sTelefono_Personal);
            Obj_BD_DAL.DtParametros.Rows.Add("@Contacto_Emergencia", "7", obj_Empleados.sContacto_Emergencia);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "7", obj_Empleados.sCorreo);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Nacimiento", "11", obj_Empleados.dFecha_Nacimiento);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Ingreso", "8", obj_Empleados.dFecha_Ingreso);
            Obj_BD_DAL.DtParametros.Rows.Add("@Puesto_ID", "1", obj_Empleados.iPuesto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Vacaciones_ID", "1", obj_Empleados.iVacaciones);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_EMPLEADOS"].ToString().Trim();

            
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Empleados.sMsjError = Obj_BD_DAL.sMsjError;
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