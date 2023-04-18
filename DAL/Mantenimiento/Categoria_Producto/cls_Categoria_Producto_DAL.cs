using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Categoria_Producto
{
    public class cls_Categoria_Producto_DAL
    { //STIVEN COMENTARIO
        #region VARIABLES PRIVADAS 
        private int _iCategoria_ID;
        private string _sNombre, _sDescripcion;

        private string _sMsjError;
        private DataTable _dtDatos;


        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iCategoria_ID { get => _iCategoria_ID; set => _iCategoria_ID = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion
    }
}
