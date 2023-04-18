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
    public partial class frm_Nueva_Contrasena : Form
    {
        public frm_Nueva_Contrasena()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cambiado la contraseña satisfactoriamente");
        }
    }
}
