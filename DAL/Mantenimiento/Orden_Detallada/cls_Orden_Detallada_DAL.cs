using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Orden_Detallada
{
    public class cls_Orden_Detallada_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iOrden_Detalle_ID, _iPlatillo_ID, _iProducto, _iCantidad, _iEmpleado_ID, _iTipo_Comanda;
        private char _cMesa;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iOrden_Detalle_ID { get => _iOrden_Detalle_ID; set => _iOrden_Detalle_ID = value; }
        public int iPlatillo_ID { get => _iPlatillo_ID; set => _iPlatillo_ID = value; }
        public int iProducto { get => _iProducto; set => _iProducto = value; }
        public int iCantidad { get => _iCantidad; set => _iCantidad = value; }
        public int iEmpleado_ID { get => _iEmpleado_ID; set => _iEmpleado_ID = value; }
        public int iTipo_Comanda { get => _iTipo_Comanda; set => _iTipo_Comanda = value; }
        public char cMesa { get => _cMesa; set => _cMesa = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion

    }
}
