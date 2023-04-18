using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Mantenimiento.Factura;

namespace Plantilla_Diseño_2.Pantallas.Facturacion
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        public cls_Factura_DAL Obj_Edit_DAL;

        private void Factura_Load(object sender, EventArgs e)
        {

            Random r = new Random();

            txt_numFact.Text = (r.Next(1000, 10000)).ToString();

            txt_subTotal_Fact_M1.Text = "***  ¢" + Obj_Edit_DAL.dSubtotal.ToString() + "  ***";
            txt_Impuesto_Fact_M1.Text = "***  ¢" + Obj_Edit_DAL.dIva.ToString() + "  ***";
            txt_Prop_Fact_M1.Text = "***  ¢" + Obj_Edit_DAL.dTIPS_Propina.ToString() + "  ***";
            txt_monto_desc_M1.Text = "***  ¢" + Obj_Edit_DAL.dDescuento.ToString() + "  ***";
            txt_CargoxServicio_Fact_M1.Text = "***  ¢" + Obj_Edit_DAL.dImpuesto_Servicio.ToString() + "  ***";
            txt_Metodo_Pago.Text = "***  " + Obj_Edit_DAL.sMetodoPago + "  ***";
            txt_Total_Fact_M1.Text = "***  ¢" + Obj_Edit_DAL.dTotal_Pago.ToString() + "  ***";
            
        }
    }
}
