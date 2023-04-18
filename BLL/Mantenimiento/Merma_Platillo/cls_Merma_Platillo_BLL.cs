using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Merma_Platillo;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Merma_Platillo
{
    class cls_Merma_Platillo_BLL
    {
        public void Listar_Filtrar_MERMA_PLATILLO(ref cls_Merma_Platillo_DAL obj_Merma_Platillo)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (obj_Merma_Platillo.iPlatillo_ID <= 0)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_MERMA_PLATILLO"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Merma_Platillo.iPlatillo_ID);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_MERMA_PLATILLO"].ToString();
            }

            Obj_BD_DAL.sNomTabla = "MERMA_PLATILLO";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                obj_Merma_Platillo.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                obj_Merma_Platillo.dtDatos = null;
            }
            obj_Merma_Platillo.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_MERMA_PLATILLO(ref cls_Merma_Platillo_DAL obj_Merma_Platillo)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", obj_Merma_Platillo.iPlatillo_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_MERMA_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            obj_Merma_Platillo.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_MERMA_PLATILLO(ref cls_Merma_Platillo_DAL obj_Merma_Platillo)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", obj_Merma_Platillo.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha", "8", obj_Merma_Platillo.dFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Motivo", "7", obj_Merma_Platillo.sMotivo);
           
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


            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["AGREGAR_MERMA_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (obj_Merma_Platillo.sMsjError == string.Empty)
            {
                obj_Merma_Platillo.iPlatillo_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            obj_Merma_Platillo.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_MERMA_PLATILLO(ref cls_Merma_Platillo_DAL obj_Merma_Platillo)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Platillo_ID", "1", obj_Merma_Platillo.iPlatillo_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Fecha", "8", obj_Merma_Platillo.dFecha);
            Obj_BD_DAL.DtParametros.Rows.Add("@Motivo", "7", obj_Merma_Platillo.sMotivo);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_MERMA_PLATILLO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            obj_Merma_Platillo.sMsjError = Obj_BD_DAL.sMsjError;
        }

    }
}
