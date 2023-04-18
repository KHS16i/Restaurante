using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Menaje
{
    public class cls_Menaje_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iMenaje_ID, _iCantidad, _iProveedor;
        private string _sNombre, _sUbicacion, _sPlaca_Serie;
        DateTime _dFecha_Registro;

        private string _sMsjError;
        private DataTable _dtDatos;

        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iMenaje_ID { get => _iMenaje_ID; set => _iMenaje_ID = value; }
        public int iCantidad { get => _iCantidad; set => _iCantidad = value; }
        public int iProveedor { get => _iProveedor; set => _iProveedor = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sUbicacion { get => _sUbicacion; set => _sUbicacion = value; }
        public string sPlaca_Serie { get => _sPlaca_Serie; set => _sPlaca_Serie = value; }
        public DateTime dFecha_Registro { get => _dFecha_Registro; set => _dFecha_Registro = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }

        #endregion
    }
}
