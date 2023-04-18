using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Categoria_Producto;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Categoria_Producto
{
    class cls_Categoria_Producto_BLL
    {
        public void Listar_Filtrar_Categoria_Productos(ref cls_Categoria_Producto_DAL obj_categoria_producto)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_categoria_producto.sNombre == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_CATEGORIA_PRODUCTO"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_categoria_producto.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_CATEGORIA_PRODUCTO"].ToString();
            }
            
            Obj_BD_DAL.sNomTabla = "CATEGORIA_PRODUCTO";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_categoria_producto.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_categoria_producto.dtDatos = null;
            }
            obj_categoria_producto.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_CATEGORIA_PRODUCTO(ref cls_Categoria_Producto_DAL obj_categoria_producto)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_categoria_producto.iCategoria_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_CATEGORIA_PRODUCTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_categoria_producto.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_CATEGORIA_PRODUCTO(ref cls_Categoria_Producto_DAL obj_categoria_producto)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

           
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_categoria_producto.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_categoria_producto.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_CATEGORIA_PRODUCTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_categoria_producto.sMsjError == string.Empty)
            {
                obj_categoria_producto.iCategoria_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_categoria_producto.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_CATEGORIA_PRODUCTO(ref cls_Categoria_Producto_DAL obj_categoria_producto)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_categoria_producto.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_categoria_producto.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_CATEGORIA_PRODUCTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_categoria_producto.sMsjError = Obj_BD_DAL.sMsjError;
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
*/