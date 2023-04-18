using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar;
using Plantilla_Diseño_2.Pantallas.Cocina;

namespace Plantilla_Diseño_2.Pantallas.Salon
{
    public partial class frm_Salon : Form
    {
        frm_Merma_Cocina obj_merma = new frm_Merma_Cocina();

        public frm_Salon()
        {
            InitializeComponent();
        }

        #region mesas_verde
        private void btn_v_mesa_I_Click(object sender, EventArgs e)
        {
            btn_v_mesa_I.Visible = false;
            btn_r_mesa_I.Visible = true;
        }


        private void btn_v_mesa_II_Click(object sender, EventArgs e)
        {
            btn_v_mesa_II.Visible = false;
            btn_r_mesa_II.Visible = true;
        }

        private void btn_v_mesa_III_Click(object sender, EventArgs e)
        {
            btn_v_mesa_III.Visible = false;
            btn_r_mesa_III.Visible = true;
        }

   
        private void btn_v_mesa_IV_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IV.Visible = false;
            btn_r_mesa_IV.Visible = true;
        }

        private void btn_v_mesa_V_Click(object sender, EventArgs e)
        {
            btn_v_mesa_V.Visible = false;
            btn_r_mesa_V.Visible = true;
        }

        private void btn_v_mesa_VI_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VI.Visible = false;
            btn_r_mesa_VI.Visible = true;
        }

        private void btn_v_mesa_VII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VII.Visible = false;
            btn_r_mesa_VII.Visible = true;
        }

        private void btn_v_mesa_VIII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VIII.Visible = false;
            btn_r_mesa_VIII.Visible = true;
        }

        private void btn_v_mesa_IX_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IX.Visible = false;
            btn_r_mesa_IX.Visible = true;
        }

        private void btn_v_mesa_X_Click(object sender, EventArgs e)
        {
            btn_v_mesa_X.Visible = false;
            btn_r_mesa_X.Visible = true;
        }

        #endregion

        #region mesas_rojo

        private void btn_r_mesa_I_Click(object sender, EventArgs e)
        {
            btn_v_mesa_I.Visible = true;
            btn_r_mesa_I.Visible = false;
        }
        private void btn_r_mesa_II_Click(object sender, EventArgs e)
        {
            btn_v_mesa_II.Visible = true;
            btn_r_mesa_II.Visible = false;
        }

        private void btn_r_mesa_III_Click(object sender, EventArgs e)
        {
            btn_v_mesa_III.Visible = true;
            btn_r_mesa_III.Visible = false;
        }

        private void btn_r_mesa_IV_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IV.Visible = true;
            btn_r_mesa_IV.Visible = false;
        }

        private void btn_r_mesa_V_Click(object sender, EventArgs e)
        {
            btn_v_mesa_V.Visible = true;
            btn_r_mesa_V.Visible = false;
        }

        private void btn_r_mesa_VI_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VI.Visible = true;
            btn_r_mesa_VI.Visible = false;
        }

        private void btn_r_mesa_VII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VII.Visible = true;
            btn_r_mesa_VII.Visible = false;
        }

        private void btn_r_mesa_VIII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VIII.Visible = true;
            btn_r_mesa_VIII.Visible = false;
        }

        private void btn_r_mesa_IX_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IX.Visible = true;
            btn_r_mesa_IX.Visible = false;
        }

        private void btn_r_mesa_X_Click(object sender, EventArgs e)
        {
            btn_v_mesa_X.Visible = true;
            btn_r_mesa_X.Visible = false;
        }

        #endregion

        #region botones_acciones_generales
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            /* cerrar icono de casa*/
            if (MessageBox.Show("Desea cerrar su sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //this.Hide();
                //Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
                //Obj_Login.ShowDialog();
                this.Close();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            /*ventana ir a home*/

            tab_mesas.SelectedIndex = 0;
            tab_crear_orden.SelectedIndex = 0;
        }

        private void btn_fulls_Click(object sender, EventArgs e)
        {
            /* maximizar ventana*/

            this.WindowState = FormWindowState.Maximized;
            btn_fulls.Visible = false;
            button28.Visible = true;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            /*regresar ventana a la normalidad*/

            this.WindowState = FormWindowState.Normal;
            btn_fulls.Visible = true;
            button28.Visible = false;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        { /* minimizar ventana*/
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            /* cerrar icono x*/

            //this.Hide();
            //Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
            //Obj_Login.ShowDialog();

            this.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            /* maximizar ventana*/

            this.WindowState = FormWindowState.Maximized;
            btn_fulls.Visible = false;
            button28.Visible = true;
        }

        #endregion

        #region botones_mover_entre_ventana
        private void btn_orden_mesa_I_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #1".ToString();
        }

        private void btn_orden_mesa_II_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #2".ToString();
        }

        private void btn_orden_mesa_III_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #3".ToString();
        }

        private void btn_orden_mesa_IV_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #4".ToString();
        }

        private void btn_orden_mesa_V_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #5".ToString();
        }

        private void btn_orden_mesa_VI_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #6".ToString();
        }

        private void btn_orden_mesa_VII_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #7".ToString();
        }

        private void btn_orden_mesa_VIII_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #8".ToString();
        }

        private void btn_orden_mesa_IX_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #9".ToString();
        }

        private void btn_orden_mesa_X_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #10".ToString();
        }

        private void btn_express_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 2;
        }

        private void btn_Main_Orden_Click(object sender, EventArgs e)
        {
            tab_salon.SelectedIndex = 0;
        }

        private void btn_Main_Mantenimiento_Click(object sender, EventArgs e)
        {
            tab_salon.SelectedIndex = 1;
        }


        #endregion

        private void button23_Click(object sender, EventArgs e)
        {
            obj_merma.ShowDialog();
        }

        private void btn_logOut_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar su sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
                Obj_Login.ShowDialog();
            }
        }
    }

}
