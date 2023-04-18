using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Diseño_2.Pantallas.Seguridad
{
    public partial class frm_Recuperar_Contrasena : Form
    {
        public frm_Recuperar_Contrasena()
        {
            InitializeComponent();
        }

        private void btn_Main_close_Click(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha enviado una contraseña temporal a su correo electrónico");
        }
    }
}
