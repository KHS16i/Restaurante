using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Mantenimiento.Vacaciones;
using DAL.BD;
using BLL.BD;
using DAL.Mantenimiento.Empleados;

namespace BLL.Mantenimiento.Vacaciones
{
    public class cls_Vacaciones_BLL
    {
        public void Listar_Filtrar_Vacaciones(ref cls_Vacaciones_DAL Obj_Vacaciones_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Vacaciones_dal.sEmpleado_ID == "" || Obj_Vacaciones_dal.sEmpleado_ID == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_VACACIONES"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Vacaciones_dal.iVacaciones_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_VACACIONES"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Vacaciones";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Vacaciones_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Vacaciones_dal.dtDatos = null;
            }
            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void Listar_Vacaciones_Disponibles_EXIST(ref cls_Vacaciones_DAL Obj_Vacaciones_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Vacaciones_dal.sEmpleado_ID);
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_VACACIONES_ID_EMPLEADO"].ToString();

            Obj_BD_DAL.sNomTabla = "Vacaciones";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Vacaciones_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Vacaciones_dal.dtDatos = null;
            }
            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void Listar_Vacaciones_Disponibles_NO_EXIST(ref cls_Vacaciones_DAL Obj_Vacaciones_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Vacaciones_dal.sEmpleado_ID);
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_EMPLEADO_DIAS_DISPONIBLES"].ToString();

            Obj_BD_DAL.sNomTabla = "Empleados";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Vacaciones_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Vacaciones_dal.dtDatos = null;
            }
            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void Insertar_Vacaciones(ref cls_Vacaciones_DAL Obj_Vacaciones_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Vacaciones_dal.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Dias_Disponibles", "2", Obj_Vacaciones_dal.dDias_Disponibles);
            Obj_BD_DAL.DtParametros.Rows.Add("@Dias_tomados", "1", Obj_Vacaciones_dal.iDias_Tomados);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Inicio_Vacaciones", "8", Obj_Vacaciones_dal.dFecha_Inicio_Vacaciones);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_VACACIONES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Vacaciones_dal.sMsjError == string.Empty)
            {
                Obj_Vacaciones_dal.iVacaciones_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void Modificar_Vacaciones(ref cls_Vacaciones_DAL Obj_Vacaciones_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Vacaciones_dal.iVacaciones_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Vacaciones_dal.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Dias_Disponibles", "2", Obj_Vacaciones_dal.dDias_Disponibles);
            Obj_BD_DAL.DtParametros.Rows.Add("@Dias_tomados", "1", Obj_Vacaciones_dal.iDias_Tomados);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Inicio_Vacaciones", "8", Obj_Vacaciones_dal.dFecha_Inicio_Vacaciones);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_VACACIONES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void Listar_Filtrar_Vacaciones_Dias_Disponibles(ref cls_Empleados_DAL obj_DAL_Empleado)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_Vacaciones_DAL Obj_Vacaciones_dal = new cls_Vacaciones_DAL();



            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", obj_DAL_Empleado.sEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Ingreso", "8", obj_DAL_Empleado.dFecha_Ingreso);
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_VACACIONES_DIAS_DISPONIBLES"].ToString();

            Obj_BD_DAL.sNomTabla = "Vacaciones";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Vacaciones_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Vacaciones_dal.dtDatos = null;
            }
            Obj_Vacaciones_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
