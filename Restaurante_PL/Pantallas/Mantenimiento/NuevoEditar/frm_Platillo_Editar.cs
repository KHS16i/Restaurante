using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Platillo_Editar : Form
    {
        public frm_Platillo_Editar()
        {
            InitializeComponent();
        }

        char cCarSep = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());
        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == cCarSep && (textBox5.SelectionStart != 0) && (!textBox5.Text.Trim().Contains(cCarSep))))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }
    }
}
