using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Factura
{
    public class cls_Factura_DAL
    {
        #region VARIABLES PRIVADAS
       
        private int _iFactura_ID, _iOrden_Detalle_ID, _iMetodo_Pago_ID;
        DateTime _dtFecha;
        private double _dSubtotal, _dIva, _dDescuento, _dImpuesto_Servicio, _dTIPS_Propina, _dTotal_Pago;
        private char _cMesa;

        private string _sMsjError, _sMetodoPago;
        private DataTable _dtDatos;

        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES

        public int iFactura_ID { get => _iFactura_ID; set => _iFactura_ID = value; }
        public int iOrden_Detalle_ID { get => _iOrden_Detalle_ID; set => _iOrden_Detalle_ID = value; }
        public int iMetodo_Pago_ID { get => _iMetodo_Pago_ID; set => _iMetodo_Pago_ID = value; }
        public DateTime dtFecha { get => _dtFecha; set => _dtFecha = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public char cMesa { get => _cMesa; set => _cMesa = value; }
        public double dSubtotal { get => _dSubtotal; set => _dSubtotal = value; }
        public double dIva { get => _dIva; set => _dIva = value; }
        public double dDescuento { get => _dDescuento; set => _dDescuento = value; }
        public double dImpuesto_Servicio { get => _dImpuesto_Servicio; set => _dImpuesto_Servicio = value; }
        public double dTIPS_Propina { get => _dTIPS_Propina; set => _dTIPS_Propina = value; }
        public double dTotal_Pago { get => _dTotal_Pago; set => _dTotal_Pago = value; }
        public string sMetodoPago { get => _sMetodoPago; set => _sMetodoPago = value; }


        #endregion

    }
}
