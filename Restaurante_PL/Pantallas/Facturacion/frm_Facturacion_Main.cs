using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Plantilla_Diseño_2.Pantallas.Administracion;
using DAL.Mantenimiento.Factura;
using BLL.Mantenimiento.Factura;
using DAL.Mantenimiento.Metodo_Pago;
using BLL.Mantenimiento.Metodo_Pago;

namespace Plantilla_Diseño_2.Pantallas.Facturacion
{
    public partial class frm_Facturacion_Main : Form
    {
        #region VARIABLES GLOBALES

        double subtotal;
        double impuesto;
        double propina;
        double descuento;
        double cargoXservicio;
        double total;

        cls_Factura_DAL obj_factura_DAL = new cls_Factura_DAL();
        cls_Factura_BLL obj_factura_BLL = new cls_Factura_BLL();

        cls_Metodo_Pago_DAL obj_metPago_DAL = new cls_Metodo_Pago_DAL();
        cls_Metodo_Pago_BLL obj_metPago_BLL = new cls_Metodo_Pago_BLL();

        #endregion

        #region EVENTOS

        public frm_Facturacion_Main()
        {
            InitializeComponent();
        }

        private void btn_cobrar_mesa1_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 1;
        }

        private void btn_cobrar_mesa2_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 2;
        }

        private void btn_cobrar_mesa3_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 3;
        }

        private void btn_cobrar_mesa4_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 4;
        }

        private void btn_cobrar_mesa5_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 5;
        }

        private void btn_cobrar_mesa6_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 6;
        }

        private void btn_cobrar_mesa7_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 7;
        }

        private void btn_cobrar_mesa8_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 8;
        }

        private void btn_cobrar_mesa9_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 9;
        }

        private void btn_cobrar_mesa10_Disp_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 10;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            tb_Facturacion.SelectedIndex = 0;
        }

        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
            Obj_Login.ShowDialog();
        }

        private void btn_Main_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Main_max.Visible = false;
            btn_Main_res.Visible = true;
        }

        private void btn_Main_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Main_res_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Main_max.Visible = true;
            btn_Main_res.Visible = false;
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar su sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
                Obj_Login.ShowDialog();
            }
        }

        private void pn_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frm_Facturacion_Main_Load(object sender, EventArgs e)
        {
            cargarDatosFactura();
            calc_Facturar();
        }

        private void btn_Pagar_mesa1_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_1_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_cobrar_mesa1_No_Disp.Visible = false;

                txt_Prop_Fact_M1.Text = "0";
                txt_Desc_Fact_M1.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_1_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_cobrar_mesa1_No_Disp.Visible = false;

                txt_Prop_Fact_M1.Text = "0";
                txt_Desc_Fact_M1.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_1_PagarSeparado.Rows.Clear();

            }


            cbx_metPago_Fact_M1.SelectedValue = "0";
        }

        private void btn_limp_M1_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M1.Text = "0";
            txt_Desc_Fact_M1.Text = "0";
            cbx_metPago_Fact_M1.SelectedValue = "0";

            dgv_Mesa_1_PagarSeparado.Rows.Clear();
            dgv_Mesa_1_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void btn_verTotal_M1_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_1_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region METODOS

        //Para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //fin codigo para mover ventana



        private void calc_Facturar()
        {
            subtotal = 0;
            impuesto = 0;
            propina = 0;
            descuento = 0;
            cargoXservicio = 0;
            total = 0;

            if (dgv_Mesa_1_PagarSeparado.Rows.Count == 0)
            {
                foreach (DataGridViewRow row in dgv_Mesa_1_TotalCuenta.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
                }
                txt_subTotal_Fact_M1.Text = subtotal.ToString();

                impuesto = subtotal * 0.13;
                txt_Impuesto_Fact_M1.Text = impuesto.ToString();

                propina = Convert.ToDouble(txt_Prop_Fact_M1.Text);

                descuento = Convert.ToDouble(txt_Desc_Fact_M1.Text);
                descuento = descuento / 100;

                cargoXservicio = subtotal * 0.10;
                txt_CargoxServicio_Fact_M1.Text = cargoXservicio.ToString();

                descuento = descuento * (subtotal + impuesto + cargoXservicio);
                txt_monto_desc_M1.Text = descuento.ToString();

                total = subtotal + impuesto + propina - descuento + cargoXservicio;
                txt_Total_Fact_M1.Text = total.ToString();

            }
            else
            {
                foreach (DataGridViewRow row in dgv_Mesa_1_PagarSeparado.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
                }
                txt_subTotal_Fact_M1.Text = subtotal.ToString();

                impuesto = subtotal * 0.13;
                txt_Impuesto_Fact_M1.Text = impuesto.ToString();

                propina = Convert.ToDouble(txt_Prop_Fact_M1.Text);

                descuento = Convert.ToDouble(txt_Desc_Fact_M1.Text);
                descuento = descuento / 100;

                cargoXservicio = subtotal * 0.10;
                txt_CargoxServicio_Fact_M1.Text = cargoXservicio.ToString();

                descuento = descuento * (subtotal + impuesto + cargoXservicio);
                txt_monto_desc_M1.Text = descuento.ToString();

                total = subtotal + impuesto + propina - descuento + cargoXservicio;
                txt_Total_Fact_M1.Text = total.ToString();
            }



        }

        private void cargarComboBoxFact()
        {

            obj_metPago_BLL.Listar_Filtrar_METODODEPAGO(ref obj_metPago_DAL);

            cbx_metPago_Fact_M1.DataSource = null;


            if (obj_metPago_DAL.sMsjError == string.Empty)
            {
                obj_metPago_DAL.dtDatos.Rows.Add("0", "--- Seleccione ---");
                cbx_metPago_Fact_M1.DataSource = obj_metPago_DAL.dtDatos;

                cbx_metPago_Fact_M1.DisplayMember = "Nombre";

                cbx_metPago_Fact_M1.ValueMember = "Metodo_Pago_ID";

            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_metPago_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void insertarDatosFactura()
        {
            DateTime fecha = DateTime.Today;

            obj_factura_DAL.iOrden_Detalle_ID = 2;//Falta informacion de Salon
            obj_factura_DAL.dtFecha = fecha;
            obj_factura_DAL.iMetodo_Pago_ID = Convert.ToInt32(cbx_metPago_Fact_M1.SelectedValue.ToString().Trim());
            //obj_factura_DAL.dSubtotal = Convert.ToDecimal(subtotal);
            //obj_factura_DAL.dIva = Convert.ToDecimal(impuesto);
            //obj_factura_DAL.dDescuento = Convert.ToDecimal(descuento);
            //obj_factura_DAL.dImpuesto_Servicio = Convert.ToDecimal(cargoXservicio);
            //obj_factura_DAL.dTIPS_Propina = Convert.ToDecimal(propina);
            //obj_factura_DAL.dTotal_Pago = Convert.ToDecimal(total);

            obj_factura_BLL.Insertar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError != string.Empty)
            {
                MessageBox.Show("Se presentó un error al tratar de agregar el Platillo seleccionado [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Factura generada exitosamente exitosamente!", "Ejecucion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pasar_a_pagar_x_separado()
        {
            dgv_Mesa_1_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_1_TotalCuenta[0, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_1_TotalCuenta[1, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_1_TotalCuenta.Rows.RemoveAt(dgv_Mesa_1_TotalCuenta.CurrentRow.Index);
        }

        private void cargarDatosFactura()
        {
            cargarComboBoxFact();//Carga el combobox de la pantalla Mesa 1 de Facturacion
            cbx_metPago_Fact_M1.SelectedValue = "0";

            dgv_Mesa_1_TotalCuenta.DataSource = null;

            obj_factura_DAL.cMesa = '1';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_1_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void cbx_metPago_Fact_M1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbx_metPago_Fact_M1.SelectedIndex.Equals(5))
            {
                btn_Pagar_mesa.Enabled = true;
            }
            else
            {
                btn_Pagar_mesa.Enabled = false;
            }
        }
    }
}
