using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Servicios_Profesionales
{
    public class cls_Servicios_Profesionales_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iServicio_ID, _iPuesto_ID, _iHoras_Laboradas;
        public decimal _dMonto_Cancelado;
        private string _sNombre, _sOferente_ID, _sServicio_recibido, _sEmpleado_ID;
        DateTime _dFecha_Servicio;
        

        private string _sMsjError;
        private DataTable _dtDatos;

        #endregion


        #region VARIABLES PUBLICAS
        public int iServicio_ID { get => _iServicio_ID; set => _iServicio_ID = value; }
        public int iPuesto_ID { get => _iPuesto_ID; set => _iPuesto_ID = value; }
        public int iHoras_Laboradas { get => _iHoras_Laboradas; set => _iHoras_Laboradas = value; }
        public string sEmpleado_ID { get => _sEmpleado_ID; set => _sEmpleado_ID = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sOferente_ID { get => _sOferente_ID; set => _sOferente_ID = value; }
        public string sServicio_recibido { get => _sServicio_recibido; set => _sServicio_recibido = value; }
        public DateTime dFecha_Servicio { get => _dFecha_Servicio; set => _dFecha_Servicio = value; }
        public decimal dMonto_Cancelado { get => _dMonto_Cancelado; set => _dMonto_Cancelado = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion


    }
}
