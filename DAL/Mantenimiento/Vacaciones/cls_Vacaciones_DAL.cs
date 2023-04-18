using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Vacaciones
{
    public class cls_Vacaciones_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iVacaciones_ID, _iDias_Tomados;
        private decimal _dDias_Disponibles;
        DateTime _dFecha_Inicio_Vacaciones;

        private string _sMsjError, _sEmpleado_ID;
        private DataTable _dtDatos;

        #endregion


        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iVacaciones_ID { get => _iVacaciones_ID; set => _iVacaciones_ID = value; }
        public string sEmpleado_ID { get => _sEmpleado_ID; set => _sEmpleado_ID = value; }
        public int iDias_Tomados { get => _iDias_Tomados; set => _iDias_Tomados = value; }
        public decimal dDias_Disponibles { get => _dDias_Disponibles; set => _dDias_Disponibles = value; }
        public DateTime dFecha_Inicio_Vacaciones { get => _dFecha_Inicio_Vacaciones; set => _dFecha_Inicio_Vacaciones = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion


    }
}
