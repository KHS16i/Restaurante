using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Mantenimiento.Puesto;
using BLL.BD;
using System.Configuration;

namespace BLL.Mantenimiento.Puesto
{
    public class cls_Puesto_BLL
    {
        public void Listar_Filtrar_Puesto(ref cls_Puesto_DAL Obj_Puesto_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Puesto_dal.sNombre == string.Empty)
            {
                Obj_BD_DAL.DtParametros = null;
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["LISTAR_PUESTO"].ToString();
            }
            else
            {
                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "7", Obj_Puesto_dal.sNombre);
                Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["FILTRAR_PUESTO"].ToString();
            }
            Obj_BD_DAL.sNomTabla = "Puesto";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Puesto_dal.dtDatos = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Puesto_dal.dtDatos = null;
            }
            Obj_Puesto_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Eliminar_Puesto(ref cls_Puesto_DAL Obj_Puesto_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.DtParametros.Rows.Add("@filtro", "1", Obj_Puesto_dal.iPuesto_ID);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["ELIMINAR_PUESTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);
            Obj_Puesto_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Insertar_Puesto(ref cls_Puesto_DAL Obj_Puesto_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Puesto_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Funciones", "7", Obj_Puesto_dal.sFunciones);
            Obj_BD_DAL.DtParametros.Rows.Add("@Salario", "10", Obj_Puesto_dal.dSalario);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["INSERTAR_PUESTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'I';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            if (Obj_Puesto_dal.sMsjError == string.Empty)
            {
                Obj_Puesto_dal.iPuesto_ID = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            Obj_Puesto_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void Modificar_Puesto(ref cls_Puesto_DAL Obj_Puesto_dal)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

            Obj_BD_DAL.DtParametros.Rows.Add("@Id_Seleccionado", "1", Obj_Puesto_dal.iPuesto_ID);
            Obj_BD_DAL.DtParametros.Rows.Add("@Nombre", "7", Obj_Puesto_dal.sNombre);
            Obj_BD_DAL.DtParametros.Rows.Add("@Funciones", "7", Obj_Puesto_dal.sFunciones);
            Obj_BD_DAL.DtParametros.Rows.Add("@Salario", "10", Obj_Puesto_dal.dSalario);

            Obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["MODIFICAR_PUESTO"].ToString().Trim();

            Obj_BD_DAL.cAccion = 'N';
            Obj_BD_BLL.Exec_Command(ref Obj_BD_DAL);

            Obj_Puesto_dal.sMsjError = Obj_BD_DAL.sMsjError;
        }
    }
}
