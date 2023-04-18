using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Proveedor
{
   public class cls_Proveedor_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iProveedor_ID;
        private string _sRazon_Social, _sNombre, _sTelefono, _sCorreo, _sDireccion, _sMetodo_pago;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES

        public int iProveedor_ID { get => _iProveedor_ID; set => _iProveedor_ID = value; }
        public string sRazon_Social { get => _sRazon_Social; set => _sRazon_Social = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sMetodo_pago { get => _sMetodo_pago; set => _sMetodo_pago = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion
    }
}
