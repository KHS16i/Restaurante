using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Productos;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Productos
{
    public class cls_Productos_BLL
    {
        public void Listar_Filtrar_Productos(ref cls_Productos_DAL Obj_Productos_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Productos_dal.sNombre == string.Empty || Obj_Productos_dal.sNombre == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_PRODUCTOS"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "6", Obj_Productos_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_PRODUCTOS"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Productos";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Productos_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Productos_dal.dtDatos = null;
            }
            Obj_Productos_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }


        public void Listar_Filtrar_Productos_2(ref cls_Productos_DAL Obj_Productos_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Productos_dal.sNombre == string.Empty || Obj_Productos_dal.sNombre == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_PRODUCTOS_2"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "6", Obj_Productos_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_PRODUCTOS"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Productos";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Productos_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Productos_dal.dtDatos = null;
            }
            Obj_Productos_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Productos(ref cls_Productos_DAL Obj_Productos_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Productos_dal.iProductoID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Productos_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Productos(ref cls_Productos_DAL Obj_Productos_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "6", Obj_Productos_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "1", Obj_Productos_dal.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Costo_x_Unidad", "10", Obj_Productos_dal.dCosto_x_Unidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Precio_Venta", "10", Obj_Productos_dal.dPrecio_Venta);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad_minima", "1", Obj_Productos_dal.iCantidad_minima);
            Obj_BD_DAL.DtParametros.Rows.Add("@Categoria_ID", "1", Obj_Productos_dal.iCategoria_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Proveedor_ID", "1", Obj_Productos_dal.iProveedor_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_registro", "8", Obj_Productos_dal.dFecha_Registro);


            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Productos_dal.sMsjError == string.Empty)
            {
                Obj_Productos_dal.iProveedor_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Productos_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Productos(ref cls_Productos_DAL Obj_Productos_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Productos_dal.iProductoID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "6", Obj_Productos_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "1", Obj_Productos_dal.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Costo_x_Unidad", "10", Obj_Productos_dal.dCosto_x_Unidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Precio_Venta", "10", Obj_Productos_dal.dPrecio_Venta);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad_minima", "1", Obj_Productos_dal.iCantidad_minima);
            Obj_BD_DAL.DtParametros.Rows.Add("@Categoria_ID", "1", Obj_Productos_dal.iCategoria_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Proveedor_ID", "1", Obj_Productos_dal.iProveedor_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha_registro", "8", Obj_Productos_dal.dFecha_Registro);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_PRODUCTOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Productos_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
