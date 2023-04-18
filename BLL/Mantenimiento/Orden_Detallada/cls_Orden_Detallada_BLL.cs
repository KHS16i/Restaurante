using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Orden_Detallada;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Orden_Detallada
{
    public class cls_Orden_Detallada_BLL
    {
        public void Listar_Filtrar_Orden_Detallada(ref cls_Orden_Detallada_DAL Obj_Orden_Detallada_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Orden_Detallada_dal.iOrden_Detalle_ID <= 0)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_ORDENDETALLADA"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Orden_Detallada_dal.iOrden_Detalle_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_ORDENDETALLADA"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Orden_Detallada";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Orden_Detallada_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Orden_Detallada_dal.dtDatos = null;
            }
            Obj_Orden_Detallada_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Orden_Detallada(ref cls_Orden_Detallada_DAL Obj_Orden_Detallada_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Orden_Detallada_dal.iPlatillo_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_ORDENDETALLADA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Orden_Detallada_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Orden_Detallada(ref cls_Orden_Detallada_DAL Obj_Orden_Detallada_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", Obj_Orden_Detallada_dal.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", Obj_Orden_Detallada_dal.iProducto);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "1", Obj_Orden_Detallada_dal.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Mesa", "5", Obj_Orden_Detallada_dal.cMesa);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "1", Obj_Orden_Detallada_dal.iEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Tipo_Comanda_ID", "1", Obj_Orden_Detallada_dal.iTipo_Comanda);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_ORDENDETALLADA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Orden_Detallada_dal.sMsjError == string.Empty)
            {
                Obj_Orden_Detallada_dal.iPlatillo_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Orden_Detallada_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Orden_Detallada(ref cls_Orden_Detallada_DAL Obj_Orden_Detallada_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Orden_Detallada_dal.iOrden_Detalle_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", Obj_Orden_Detallada_dal.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Producto_ID", "1", Obj_Orden_Detallada_dal.iProducto);
            Obj_BD_DAL.DtParametros.Rows.Add("@Cantidad", "1", Obj_Orden_Detallada_dal.iCantidad);
            Obj_BD_DAL.DtParametros.Rows.Add("@Mesa", "5", Obj_Orden_Detallada_dal.cMesa);
            Obj_BD_DAL.DtParametros.Rows.Add("@Empleado_ID", "1", Obj_Orden_Detallada_dal.iEmpleado_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Tipo_Comanda_ID", "1", Obj_Orden_Detallada_dal.iTipo_Comanda);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_ORDENDETALLADA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Orden_Detallada_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
