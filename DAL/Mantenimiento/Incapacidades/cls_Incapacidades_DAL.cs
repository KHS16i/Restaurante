using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Incapacidades
{
public class cls_Incapacidades_DAL
    {

        #region VARIABLES PRIVADAS

        private int _iIncapacidad_ID, _iNuemro_Orden;
        DateTime _dFecha_Inicio, _dFecha_Final;
        private string _sDescripcion, _sEmpleado_ID;

        private string _sMsjError;
        private DataTable _dtDatos;


        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iIncapacidad_ID { get => _iIncapacidad_ID; set => _iIncapacidad_ID = value; }
        public string sEmpleado_ID { get => _sEmpleado_ID; set => _sEmpleado_ID = value; }
        public int iNuemro_Orden { get => _iNuemro_Orden; set => _iNuemro_Orden = value; }
        public DateTime dFecha_Inicio { get => _dFecha_Inicio; set => _dFecha_Inicio = value; }
        public DateTime dFecha_Final { get => _dFecha_Final; set => _dFecha_Final = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }



        #endregion

    }
}
/*
case "1": TipoDatoSQL = SqlDbType.Int;
case "2": TipoDatoSQL = SqlDbType.Decimal;
case "3": TipoDatoSQL = SqlDbType.Float;
case "4": TipoDatoSQL = SqlDbType.Char;
case "5": TipoDatoSQL = SqlDbType.NChar;
case "6": TipoDatoSQL = SqlDbType.VarChar;
case "7": TipoDatoSQL = SqlDbType.NVarChar;
case "8": TipoDatoSQL = SqlDbType.DateTime;
case "9": TipoDatoSQL = SqlDbType.Bit;
case "10": TipoDatoSQL = SqlDbType.Money;
case "11": TipoDatoSQL = SqlDbType.Date;
*/
