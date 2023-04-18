using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using Restaurante_DAL.Login;
//using Restaurante_BLL.Login;
using Plantilla_Diseño_2.Pantallas.Administracion;
using Plantilla_Diseño_2.Pantallas.Cocina;
using Plantilla_Diseño_2.Pantallas.Salon;
using Plantilla_Diseño_2.Pantallas.Facturacion;


namespace Plantilla_Diseño_2.Pantallas.Login
{
    public partial class frm_Login : Form
    {

        #region VARIABLES GLOBALES
        frm_Cocina obj_cocina_frm = new frm_Cocina();
        frm_Facturacion_Main obj_facturacion_frm = new frm_Facturacion_Main();
        frm_Salon obj_salon_frm = new frm_Salon();
        frm_administracion obj_administracion_frm = new frm_administracion();
      

        #endregion

        #region EVENTOS

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string pantalla = txt_login_Nombre.Text.Trim().ToLower();



            if (txt_login_password.Text.Contains("test"))
            {
                tb_Login_Main.SelectedIndex = 2;
            }
            else
            {
                switch (pantalla)
                {
                    case "admin":
                        obj_administracion_frm.ShowDialog();
                        this.Hide();
                        break;

                    case "cocina":
                        obj_cocina_frm.ShowDialog();
                        this.Hide();
                        break;

                    case "salon":
                        obj_salon_frm.ShowDialog();
                        this.Hide();
                        break;

                    case "factura":
                        obj_facturacion_frm.ShowDialog();
                        this.Hide();
                        break;

                    default:
                        obj_administracion_frm.ShowDialog();
                        break;
                }
            }
           

        }

        private void btn_login_clear_Click(object sender, EventArgs e)
        {
            txt_login_Nombre.Text = string.Empty;
            txt_login_password.Text = string.Empty;
        }

        private void btn_Login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_cerrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Login_recConstrasena_Click(object sender, EventArgs e)
        {
            tb_Login_Main.SelectedIndex = 1;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            tb_Login_Main.SelectedIndex = 0;
        }
        private void btn_RecConAceptar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == string.Empty)//Metodo para validar correo falta aca
            {
                MessageBox.Show("Por favor digite un correo electronico valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se le enviará un correo con una nueva contraseña temporal", "Recuperacion de Usuario/Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                txt_email.Text = string.Empty;
                txt_login_Nombre.Text = string.Empty;
                txt_login_password.Text = string.Empty;
                tb_Login_Main.SelectedIndex = 0;

            }
        }

        private void btn_volverAgregarContraseña_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text = string.Empty;
            txt_contraseña2.Text = string.Empty;
            tb_Login_Main.SelectedIndex = 0;
        }
        private void btn_agregarContraseña_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == string.Empty)
            {
                MessageBox.Show("Contraseña no permitida", "Recuperacion de Usuario/Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_contraseña.Text.Equals(txt_contraseña2.Text))//revisar
            {
                MessageBox.Show("Las contraseñas no coinciden!!", "Recuperacion de Usuario/Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se ha registrado la contraseña exitosamente", "Recuperacion de Usuario/Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_contraseña.Text = string.Empty;
                txt_contraseña2.Text = string.Empty;
                txt_login_Nombre.Text = string.Empty;
                txt_login_password.Text = string.Empty;
                tb_Login_Main.SelectedIndex = 0;
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

        #endregion

    }
}
