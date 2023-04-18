using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL.BD
{
    public class cls_BD_DAL
    {

        #region VARIABLES_PRIVADAS

        private SqlConnection _Obj_SqlCnx;
        private SqlDataAdapter _Obj_SqlDap;
        private SqlCommand _Obj_Sql_Cmd;

        private DataSet _Ds;
        private DataTable _DtParametros;

        private string _sMsjError, _sNomSP, _sNomTabla, _sValorScalar;

        private char _cAccion;

        #endregion

        #region CONSTRUCTORES

        public SqlConnection Obj_SqlCnx { get => _Obj_SqlCnx; set => _Obj_SqlCnx = value; }
        public SqlDataAdapter Obj_SqlDap { get => _Obj_SqlDap; set => _Obj_SqlDap = value; }
        public SqlCommand Obj_Sql_Cmd { get => _Obj_Sql_Cmd; set => _Obj_Sql_Cmd = value; }
        public DataSet Ds { get => _Ds; set => _Ds = value; }
        public DataTable DtParametros { get => _DtParametros; set => _DtParametros = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sNomSP { get => _sNomSP; set => _sNomSP = value; }
        public string sNomTabla { get => _sNomTabla; set => _sNomTabla = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public char cAccion { get => _cAccion; set => _cAccion = value; }

        #endregion

    }
}
