using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Menu;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Menu
{
    public class cls_Menu_BLL
    {
        public void Listar_Filtrar_MENU(ref cls_Menu_DAL obj_Menu)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Menu.iMenu_ID <= 0)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_MENU"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Menu.iMenu_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_MENU"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "MENU";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Menu.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Menu.dtDatos = null;
            }
            obj_Menu.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_MENU(ref cls_Menu_DAL obj_Menu)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Menu.iMenu_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_MENU"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Menu.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_MENU(ref cls_Menu_DAL obj_Menu)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Menu_ID", "1", obj_Menu.iMenu_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", obj_Menu.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", obj_Menu.iProducto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "7", obj_Menu.sCantidad);
           

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_MENU"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Menu.sMsjError == string.Empty)
            {
                obj_Menu.iMenu_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_Menu.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_MENU(ref cls_Menu_DAL obj_Menu)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Menu_ID", "1", obj_Menu.iMenu_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", obj_Menu.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", obj_Menu.iProducto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "7", obj_Menu.sCantidad);
            
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_MENU"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Menu.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
