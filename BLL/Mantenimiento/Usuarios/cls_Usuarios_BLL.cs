using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Usuarios;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Usuarios
{
    public class cls_Usuarios_BLL
    {

        public void Listar_Filtrar_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Usuarios_dal.sUsuario == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_USUARIOS"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Usuarios_dal.sUsuario);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_USUARIOS"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Usuarios";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Usuarios_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Usuarios_dal.dtDatos = null;
            }
            Obj_Usuarios_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Usuarios_dal.iUsuario_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_USUARIOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Usuarios_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Usuario", "7", Obj_Usuarios_dal.sUsuario);
            Obj_BD_DAL.DtParametros.Rows.Add("@Clave", "7", Obj_Usuarios_dal.sClave);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "1", Obj_Usuarios_dal.iEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Codigo_Recuperacion", "7", Obj_Usuarios_dal.sCodigo_Recuperacion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_USUARIOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Usuarios_dal.sMsjError == string.Empty)
            {
                Obj_Usuarios_dal.iUsuario_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Usuarios_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Usuarios_dal.iUsuario_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Usuario", "7", Obj_Usuarios_dal.sUsuario);
            Obj_BD_DAL.DtParametros.Rows.Add("@Clave", "7", Obj_Usuarios_dal.sClave);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "1", Obj_Usuarios_dal.iEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Codigo_Recuperacion", "7", Obj_Usuarios_dal.sCodigo_Recuperacion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_USUARIOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Usuarios_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
