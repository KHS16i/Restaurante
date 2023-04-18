using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Proveedor;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Proveedor
{
    public class cls_Proveedor_BLL
    {
        public void Listar_Filtrar_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Proveedor_dal.sNombre == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_PROVEEVOR"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Proveedor_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_PROVEEVOR"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Proveedor";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Proveedor_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Proveedor_dal.dtDatos = null;
            }
            Obj_Proveedor_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Proveedor_dal.iProveedor_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_PROVEEVOR"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Proveedor_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Razon_Social_o_ID", "7", Obj_Proveedor_dal.sRazon_Social);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Proveedor_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono", "5", Obj_Proveedor_dal.sTelefono);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "7", Obj_Proveedor_dal.sCorreo);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", Obj_Proveedor_dal.sDireccion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Metodo_pago", "7", Obj_Proveedor_dal.sMetodo_pago);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_PROVEEVOR"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Proveedor_dal.sMsjError == string.Empty)
            {
                Obj_Proveedor_dal.iProveedor_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Proveedor_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Proveedor_dal.iProveedor_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Razon_Social_o_ID", "7", Obj_Proveedor_dal.sRazon_Social);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Proveedor_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Telefono", "5", Obj_Proveedor_dal.sTelefono);
            Obj_BD_DAL.DtParametros.Rows.Add("@Correo", "7", Obj_Proveedor_dal.sCorreo);
            Obj_BD_DAL.DtParametros.Rows.Add("@Direccion", "7", Obj_Proveedor_dal.sDireccion);
            Obj_BD_DAL.DtParametros.Rows.Add("@Metodo_pago", "7", Obj_Proveedor_dal.sMetodo_pago);
            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_PROVEEDOR"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Proveedor_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
