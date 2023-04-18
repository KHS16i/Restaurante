using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Tipo_Comanda
{
    public class cls_Tipo_Comanda_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iTipo_Comanda;
        private string _sNombre, _sDescripcion;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O COSNTRUCTORES

        public int iTipo_Comanda { get => _iTipo_Comanda; set => _iTipo_Comanda = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion


    }
}
