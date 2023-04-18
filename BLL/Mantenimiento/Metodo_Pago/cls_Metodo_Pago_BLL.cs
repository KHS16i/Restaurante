using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Metodo_Pago;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Metodo_Pago
{
    public class cls_Metodo_Pago_BLL
    {
        public void Listar_Filtrar_METODODEPAGO(ref cls_Metodo_Pago_DAL obj_Metodo_Pago)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Metodo_Pago.sNombre == null)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_METODODEPAGO"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Metodo_Pago.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_METODODEPAGO"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "METODODEPAGO";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Metodo_Pago.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Metodo_Pago.dtDatos = null;
            }
            obj_Metodo_Pago.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_METODODEPAGO(ref cls_Metodo_Pago_DAL obj_Metodo_Pago)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", obj_Metodo_Pago.sNombre);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_METODODEPAGO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Metodo_Pago.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_METODODEPAGO(ref cls_Metodo_Pago_DAL obj_Metodo_Pago)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Metodo_Pago.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_Metodo_Pago.sDescripcion);
            
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_METODODEPAGO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Metodo_Pago.sMsjError == string.Empty)
            {
                obj_Metodo_Pago.sNombre = Obj_BD_DAL.sValorScalar;
            }
            obj_Metodo_Pago.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_METODODEPAGO(ref cls_Metodo_Pago_DAL obj_Metodo_Pago)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", obj_Metodo_Pago.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Descripcion", "7", obj_Metodo_Pago.sDescripcion);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_METODODEPAGO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Metodo_Pago.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
