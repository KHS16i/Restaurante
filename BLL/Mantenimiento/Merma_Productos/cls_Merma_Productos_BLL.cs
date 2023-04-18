using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Merma_Productos;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Merma_Productos
{
    class cls_Merma_Productos_BLL
    {
        public void Listar_Filtrar_MERMA_PRODUCTOS(ref cls_Merma_Productos_DAL obj_Merma_Productos)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Merma_Productos.iProducto_ID <= 0)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_MERMA_PRODUCTOS"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Merma_Productos.iProducto_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_MERMA_PRODUCTOS"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "MERMA_PRODUCTOS";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Merma_Productos.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Merma_Productos.dtDatos = null;
            }
            obj_Merma_Productos.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_MERMA_PRODUCTOS(ref cls_Merma_Productos_DAL obj_Merma_Productos)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Merma_Productos.iProducto_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_MERMA_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Merma_Productos.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_MERMA_PRODUCTOS(ref cls_Merma_Productos_DAL obj_Merma_Productos)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", obj_Merma_Productos.iProducto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha", "8", obj_Merma_Productos.dFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Motivo", "7", obj_Merma_Productos.sMotivo);
           
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_MERMA_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Merma_Productos.sMsjError == string.Empty)
            {
                obj_Merma_Productos.iProducto_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_Merma_Productos.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_MERMA_PRODUCTOS(ref cls_Merma_Productos_DAL obj_Merma_Productos)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", obj_Merma_Productos.iProducto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha", "8", obj_Merma_Productos.dFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Motivo", "7", obj_Merma_Productos.sMotivo);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_MERMA_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Merma_Productos.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
