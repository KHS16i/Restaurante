using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Tipo_Comanda;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Tipo_Comanda
{
    public class cls_Tipo_Comanda_BLL
    {

        public void Listar_Filtrar_Tipo_Comanda(ref cls_Tipo_Comanda_DAL Obj_Tipo_Comanda_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Tipo_Comanda_dal.sNombre == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_TIPO_COMANDA"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Tipo_Comanda_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_TIPO_COMANDA"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Tipo_Comanda";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Tipo_Comanda_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Tipo_Comanda_dal.dtDatos = null;
            }
            Obj_Tipo_Comanda_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Tipo_Comanda(ref cls_Tipo_Comanda_DAL Obj_Tipo_Comanda_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Tipo_Comanda_dal.iTipo_Comanda);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_TIPO_COMANDA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Tipo_Comanda_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Tipo_Comanda(ref cls_Tipo_Comanda_DAL Obj_Tipo_Comanda_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Tipo_Comanda_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", Obj_Tipo_Comanda_dal.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_TIPO_COMANDA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Tipo_Comanda_dal.sMsjError == string.Empty)
            {
                Obj_Tipo_Comanda_dal.iTipo_Comanda = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Tipo_Comanda_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Tipo_Comanda(ref cls_Tipo_Comanda_DAL Obj_Tipo_Comanda_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Tipo_Comanda_dal.iTipo_Comanda);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Tipo_Comanda_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", Obj_Tipo_Comanda_dal.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_TIPO_COMANDA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Tipo_Comanda_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }


    }
}
