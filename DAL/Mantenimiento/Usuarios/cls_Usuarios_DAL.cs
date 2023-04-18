using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Usuarios
{
    public class cls_Usuarios_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iUsuario_ID, _iEmpleado_ID;
        private string _sUsuario, _sClave, _sCodigo_Recuperacion;

        private string _sMsjError;
        private DataTable _dtDatos;
        #endregion


        #region VARIABLES PUBLICAS O CONSTRUCORES
        public int iUsuario_ID { get => _iUsuario_ID; set => _iUsuario_ID = value; }
        public int iEmpleado_ID { get => _iEmpleado_ID; set => _iEmpleado_ID = value; }
        public string sUsuario { get => _sUsuario; set => _sUsuario = value; }
        public string sClave { get => _sClave; set => _sClave = value; }
        public string sCodigo_Recuperacion { get => _sCodigo_Recuperacion; set => _sCodigo_Recuperacion = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        #endregion

    }
}
