using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Platillo
{
  public  class cls_Platillo_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iPlatillo_ID;
        private string _sNombre;
        private decimal _dPrecio_Con_IVA;

        private string _sMsjError;
        private char _cIdEstado, _cOperacion;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iPlatillo_ID { get => _iPlatillo_ID; set => _iPlatillo_ID = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public decimal dPrecio_Con_IVA { get => _dPrecio_Con_IVA; set => _dPrecio_Con_IVA = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public char cIdEstado { get => _cIdEstado; set => _cIdEstado = value; }
        public char cOperacion { get => _cOperacion; set => _cOperacion = value; }

        #endregion

    }
}
