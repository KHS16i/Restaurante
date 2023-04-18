using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimiento.Merma_Productos
{
    public class cls_Merma_Productos_DAL
    {
        #region  #VARIABLES PRIVADAS
       
        private int _iMerma_Producto_ID, _iProducto_ID;
        private string _sMotivo;
        DateTime _dFecha;

        private string _sMsjError;
        private DataTable _dtDatos;


        #endregion

        #region VARIABLES PUBLICAS O CONSTRUCTORES
        public int iMerma_Producto_ID { get => _iMerma_Producto_ID; set => _iMerma_Producto_ID = value; }
        public int iProducto_ID { get => _iProducto_ID; set => _iProducto_ID = value; }
        public string sMotivo { get => _sMotivo; set => _sMotivo = value; }
        public DateTime dFecha { get => _dFecha; set => _dFecha = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion

    }
}