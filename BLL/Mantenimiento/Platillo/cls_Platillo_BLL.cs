using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Platillo;
using BLL.BD;
using System.Configuration;


namespace BLL.Mantenimiento.Platillo
{
    public class cls_Platillo_BLL
    {
        public void Listar_Filtrar_Platillo(ref cls_Platillo_DAL Obj_Platillo_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Platillo_dal.sNombre == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_PLATILLO"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "6", Obj_Platillo_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_PLATILLO"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Platillo";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Platillo_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Platillo_dal.dtDatos = null;
            }
            Obj_Platillo_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Platillo(ref cls_Platillo_DAL Obj_Platillo_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Platillo_dal.iPlatillo_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Platillo_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Platillo(ref cls_Platillo_DAL Obj_Platillo_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "6", Obj_Platillo_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Precio_Con_IVA", "10", Obj_Platillo_dal.dPrecio_Con_IVA);
      
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Platillo_dal.sMsjError == string.Empty)
            {
                Obj_Platillo_dal.iPlatillo_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Platillo_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Platillo(ref cls_Platillo_DAL Obj_Platillo_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Platillo_dal.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "6", Obj_Platillo_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Precio_Con_IVA", "10", Obj_Platillo_dal.dPrecio_Con_IVA);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Platillo_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
