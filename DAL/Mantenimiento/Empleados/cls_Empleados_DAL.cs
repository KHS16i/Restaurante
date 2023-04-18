using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Empleados
{
    public class cls_Empleados_DAL
    {

        #region Privadas

        private DateTime _dtmFecha_II;
        private TimeSpan _tspDiffDates;

        private int  _iPuesto_ID, _iVacaciones;
        private string _sEmpleado_ID, _sNombre, _sApellidos, _sDireccion, _sTelefono_Personal, _sContacto_Emergencia, _sCorreo;
        private DateTime _dFecha_Nacimiento, _dFecha_Ingreso;

        private string _sMsjError;
        private DataTable _dtDatos;

        #endregion

        #region Constructores

        public DateTime dtmFecha_II { get => _dtmFecha_II; set => _dtmFecha_II = value; }
        public TimeSpan tspDiffDates { get => _tspDiffDates; set => _tspDiffDates = value; }
       
        public string sEmpleado_ID { get => _sEmpleado_ID; set => _sEmpleado_ID = value; }
        public int iPuesto_ID { get => _iPuesto_ID; set => _iPuesto_ID = value; }
        public int iVacaciones { get => _iVacaciones; set => _iVacaciones = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sTelefono_Personal { get => _sTelefono_Personal; set => _sTelefono_Personal = value; }
        public string sContacto_Emergencia { get => _sContacto_Emergencia; set => _sContacto_Emergencia = value; }
        public DateTime dFecha_Nacimiento { get => _dFecha_Nacimiento; set => _dFecha_Nacimiento = value; }
        public DateTime dFecha_Ingreso { get => _dFecha_Ingreso; set => _dFecha_Ingreso = value; }
        
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }


        #endregion

    }
}
