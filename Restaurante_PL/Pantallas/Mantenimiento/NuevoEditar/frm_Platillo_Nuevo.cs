using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DAL.BD;
using BLL.BD;
using DAL.Mantenimiento.Platillo;
using BLL.Mantenimiento.Platillo;


namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Platillo_Nuevo : Form
    {
        #region VARIABLES GLOBLALES

        public cls_Platillo_DAL Obj_Edit_DAL;

        cls_Platillo_BLL Obj_Platillos_BLL = new cls_Platillo_BLL();


        #endregion

        #region EVENTOS

        public frm_Platillo_Nuevo()
        {
            InitializeComponent();
        }

        char cCarSep = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());
        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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


        #endregion

        #region METODOS

        #endregion

        private void button10_Click(object sender, EventArgs e)//Boton guardar
        {
            Obj_Edit_DAL.sNombre = txt_Nombre.Text.Trim();
            Obj_Edit_DAL.dPrecio_Con_IVA = Convert.ToDecimal(textBox5.Text.Trim());

            if (Obj_Edit_DAL.cOperacion == 'I')
            {
                Obj_Platillos_BLL.Insertar_Platillo(ref Obj_Edit_DAL);

                if (Obj_Edit_DAL.sMsjError != string.Empty)
                {
                    MessageBox.Show("Se presentó un error al tratar de agregar el Platillo seleccionado [ " + Obj_Edit_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Platillo ingresado al sistema exitosamente!", "Ejecucion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Obj_Edit_DAL.cOperacion = 'U';
                }
            }
            else
            {
                Obj_Platillos_BLL.Modificar_Platillo(ref Obj_Edit_DAL);

                if (Obj_Edit_DAL.sMsjError != string.Empty)
                {
                    MessageBox.Show("Se presentó un error al tratar al modificar el Platillo seleccionado [ " + Obj_Edit_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Platillo modificado exitosamente!", "Ejecucion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Obj_Edit_DAL.cOperacion = 'U';
                }
            }

            Close();


        }
    }
}
