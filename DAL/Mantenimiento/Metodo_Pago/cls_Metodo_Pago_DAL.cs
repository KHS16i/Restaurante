using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Metodo_Pago
{
   public  class cls_Metodo_Pago_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iMetodo_Pago;
        private string _sNombre, _sDescripcion;

        private string _sMsjError;
        private DataTable _dtDatos;

        #endregion


        #region  VARIABLES PUBLICAS O CONSTRUCTORES

        public int iMetodo_Pago { get => _iMetodo_Pago; set => _iMetodo_Pago = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion


    }
}
