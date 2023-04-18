using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Menu
{
    public class cls_Menu_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iMenu_ID, _iPlatillo_ID, _iProducto_ID;
        private string _sCantidad;

        private string _sMsjError;
        private DataTable _dtDatos;

        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iMenu_ID { get => _iMenu_ID; set => _iMenu_ID = value; }
        public int iPlatillo_ID { get => _iPlatillo_ID; set => _iPlatillo_ID = value; }
        public string sCantidad { get => _sCantidad; set => _sCantidad = value; }
        public int iProducto_ID { get => _iProducto_ID; set => _iProducto_ID = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion
    }
}
