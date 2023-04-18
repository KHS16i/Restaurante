using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Puesto
{
    public class cls_Puesto_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iPuesto_ID;
        private string _sNombre, _sFunciones;
        private decimal _dSalario;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iPuesto_ID { get => _iPuesto_ID; set => _iPuesto_ID = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sFunciones { get => _sFunciones; set => _sFunciones = value; }
        public decimal dSalario { get => _dSalario; set => _dSalario = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion

    }
}
