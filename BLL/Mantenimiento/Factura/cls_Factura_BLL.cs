using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Factura;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Factura
{
    public class cls_Factura_BLL
    {
        public void Listar_Filtrar_Factura(ref cls_Factura_DAL obj_Factura)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@Mesa", "4", obj_Factura.cMesa);
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_ORDEN"].ToString();

            /*if (obj_Factura.iFactura_ID <= 0)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_ORDEN"].ToString();
            }
            else
            {

            }*/

            Obj_BD_DAL.sNomTabla = "FACTURA";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Factura.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Factura.dtDatos = null;
            }
            obj_Factura.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Factura(ref cls_Factura_DAL obj_Factura)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Factura.iFactura_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_FACTURA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Factura.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Factura(ref cls_Factura_DAL obj_Factura)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Orden_Detalle_ID", "1", obj_Factura.iOrden_Detalle_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@fecha", "8", obj_Factura.dtFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Metodo_Pago_ID", "1", obj_Factura.iMetodo_Pago_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Subtotal", "2", obj_Factura.dSubtotal);
            Obj_BD_DAL.DtParametros.Rows.Add("@IVA", "2", obj_Factura.dIva);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descuento", "2", obj_Factura.dDescuento);
            Obj_BD_DAL.DtParametros.Rows.Add("@Impuesto_Servicio", "2", obj_Factura.dImpuesto_Servicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@TIPS_Propina", "2", obj_Factura.dTIPS_Propina);
            Obj_BD_DAL.DtParametros.Rows.Add("@Total_Pago", "2", obj_Factura.dTotal_Pago);


            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_FACTURA"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Factura.sMsjError == string.Empty)
            {
                obj_Factura.iFactura_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_Factura.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Factura(ref cls_Factura_DAL obj_Factura)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Orden_Detallada_ID", "1", obj_Factura.iOrden_Detalle_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@fecha", "8", obj_Factura.dtFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Metodo_Pago_ID", "1", obj_Factura.iMetodo_Pago_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Subtotal", "2", obj_Factura.dSubtotal);
            Obj_BD_DAL.DtParametros.Rows.Add("@IVA", "2", obj_Factura.dIva);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descuento", "2", obj_Factura.dDescuento);
            Obj_BD_DAL.DtParametros.Rows.Add("@Impuesto_Servicio", "2", obj_Factura.dImpuesto_Servicio);
            Obj_BD_DAL.DtParametros.Rows.Add("@TIPS_Propina", "2", obj_Factura.dTIPS_Propina);
            Obj_BD_DAL.DtParametros.Rows.Add("@Total_Pago", "2", obj_Factura.dTotal_Pago);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_EMPLEADOS"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Factura.sMsjError = Obj_BD_DAL.sMsjError;
        }

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
