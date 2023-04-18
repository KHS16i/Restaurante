using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Productos
{
   public class cls_Productos_DAL
    {
        #region VARIABLE PRIVADA

        private int _iProductoID, _iCantidad, _iCantidad_minima, _iCategoria_ID, _iProveedor_ID;
        private decimal _dCosto_x_Unidad, _dPrecio_Venta;
        DateTime _dFecha_Registro;
        private string _sNombre;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iProductoID { get => _iProductoID; set => _iProductoID = value; }
        public int iCantidad { get => _iCantidad; set => _iCantidad = value; }
        public int iCantidad_minima { get => _iCantidad_minima; set => _iCantidad_minima = value; }
        public int iCategoria_ID { get => _iCategoria_ID; set => _iCategoria_ID = value; }
        public int iProveedor_ID { get => _iProveedor_ID; set => _iProveedor_ID = value; }
        public decimal dCosto_x_Unidad { get => _dCosto_x_Unidad; set => _dCosto_x_Unidad = value; }
        public decimal dPrecio_Venta { get => _dPrecio_Venta; set => _dPrecio_Venta = value; }
        public DateTime dFecha_Registro { get => _dFecha_Registro; set => _dFecha_Registro = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion

    }
}
