using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Servicios_Profesionales;
using BLL.BD;
using System.Configuration;


namespace BLL.Mantenimiento.Servicios_Profesionales
{
    public class cls_Servicios_Profecionales_BLL
    {
        public void Listar_Filtrar_Servicios_Profesionales(ref cls_Servicios_Profesionales_DAL Obj_Servicios_Profesionales_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Servicios_Profesionales_dal.sServicio_recibido == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_SERVICIOS_PROFESIONALES"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Servicios_Profesionales_dal.sServicio_recibido);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_SERVICIOS_PROFESIONALES"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Servicios_Profesionales";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Servicios_Profesionales_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Servicios_Profesionales_dal.dtDatos = null;
            }
            Obj_Servicios_Profesionales_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Servicios_Profesionales(ref cls_Servicios_Profesionales_DAL Obj_Servicios_Profesionales_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Servicios_Profesionales_dal.iServicio_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_SERVICIOS_PROFESIONALES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Servicios_Profesionales_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Servicios_Profesionales(ref cls_Servicios_Profesionales_DAL Obj_Servicios_Profesionales_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Servicios_Profesionales_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Oferente_ID", "7", Obj_Servicios_Profesionales_dal.sOferente_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Puesto_ID", "1", Obj_Servicios_Profesionales_dal.iPuesto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Horas_Laboradas", "1", Obj_Servicios_Profesionales_dal.iHoras_Laboradas);
            Obj_BD_DAL.DtParametros.Rows.Add("@Monto_Cancelado", "10", Obj_Servicios_Profesionales_dal.dMonto_Cancelado);
            Obj_BD_DAL.DtParametros.Rows.Add("@Servicio_recibido", "7", Obj_Servicios_Profesionales_dal.sServicio_recibido);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Servicio", "8", Obj_Servicios_Profesionales_dal.dFecha_Servicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Servicios_Profesionales_dal.sEmpleado_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_SERVICIOS_PROFESIONALES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Servicios_Profesionales_dal.sMsjError == string.Empty)
            {
                Obj_Servicios_Profesionales_dal.iServicio_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Servicios_Profesionales_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Servicios_Profesionales(ref cls_Servicios_Profesionales_DAL Obj_Servicios_Profesionales_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Servicios_Profesionales_dal.iServicio_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Servicios_Profesionales_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Oferente_ID", "7", Obj_Servicios_Profesionales_dal.sOferente_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Puesto_ID", "1", Obj_Servicios_Profesionales_dal.iPuesto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Horas_Laboradas", "1", Obj_Servicios_Profesionales_dal.iHoras_Laboradas);
            Obj_BD_DAL.DtParametros.Rows.Add("@Monto_Cancelado", "10", Obj_Servicios_Profesionales_dal.dMonto_Cancelado);
            Obj_BD_DAL.DtParametros.Rows.Add("@Servicio_recibido", "7", Obj_Servicios_Profesionales_dal.sServicio_recibido);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_Servicio", "8", Obj_Servicios_Profesionales_dal.dFecha_Servicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "7", Obj_Servicios_Profesionales_dal.sEmpleado_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_SERVICIOS_PROFESIONALES"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Servicios_Profesionales_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
