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
using DAL.Mantenimiento.Puesto;
using BLL.Mantenimiento.Puesto;


namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Puesto_Nuevo : Form
    {
        public frm_Puesto_Nuevo()
        {
            InitializeComponent();
        }

        cls_Puesto_DAL obj_DAL_Puesto = new cls_Puesto_DAL();
        cls_Puesto_BLL obj_BLL_Puesto = new cls_Puesto_BLL();

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validaciones


        private void Validaciones_Letras(TextBox txt, KeyPressEventArgs e)
        {
            {
                if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == 44))
                {
                    if ((e.KeyChar == (char)Keys.Space) && (txt.SelectionStart == 0))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {

                    e.Handled = true;
                }
            }

        }
        private void Validaciones_Numeros(TextBox txt, KeyPressEventArgs e)
        {
            {
                char cCarSep = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());


                if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == cCarSep))
                {
                    if (((e.KeyChar == cCarSep) && (txt.SelectionStart == 0)) ||
                    ((e.KeyChar == cCarSep) && (txt.Text.Trim().Contains(cCarSep))))
                    {
                        e.Handled = true;
                    }
                    else
                    {

                        e.Handled = false;

                    }
                }
                else
                {
                    e.Handled = true;
                }

            }

        }
        private void Validaciones_Masked_Numeros(MaskedTextBox txt, KeyPressEventArgs e)
        {
            {
                char cCarSep = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());
                char cNegativo = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NegativeSign.ToString());

                if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == cNegativo) || (e.KeyChar == cCarSep))
                {
                    if ((((char.IsNumber(e.KeyChar)) || (e.KeyChar == cCarSep)) && (txt.SelectionStart == 0) && txt.Text.Contains(cNegativo)) ||
                    ((e.KeyChar == cNegativo) && (txt.SelectionStart != 0)) ||
                    ((e.KeyChar == cNegativo) && (txt.Text.Trim().Contains(cNegativo))) ||
                    ((e.KeyChar == cCarSep) && (txt.SelectionStart == 0)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (((e.KeyChar == cCarSep) && txt.Text.ToString().StartsWith("-") && (txt.SelectionStart == 1)) ||
                        ((e.KeyChar == cCarSep) && (txt.Text.Trim().Contains(cCarSep)) || (e.KeyChar == cCarSep) || (e.KeyChar == cNegativo)))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }

            }

        }
        private void Validaciones_Direccion(TextBox txt, KeyPressEventArgs e)
        {
            {
                if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == 44) || (char.IsNumber(e.KeyChar)))
                {
                    if ((e.KeyChar == (char)Keys.Space) && (txt.SelectionStart == 0))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {

                    e.Handled = true;
                }
            }

        }


        #endregion

        #region KeyPress

        private void txt_Nombre_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Letras(txt_Nombre_Puesto, e);
        }
        private void txt_Funciones_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Funciones_Puesto, e);
        }
        private void txt_Salario_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Numeros(txt_Salario_Puesto, e);
        }


        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (txt_Nombre_Puesto.Text.Equals("") || txt_Funciones_Puesto.Text.Equals("") || txt_Salario_Puesto.Text.Equals(""))
            {
                MessageBox.Show("Verifique que no hayan espacios en blanco.", "Espacios vacios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                obj_DAL_Puesto.sNombre = "";
            }
            else
            {
                obj_DAL_Puesto.sNombre = txt_Nombre_Puesto.Text.Trim();
                obj_DAL_Puesto.sFunciones = txt_Funciones_Puesto.Text.Trim();
                obj_DAL_Puesto.dSalario = Convert.ToDecimal(txt_Salario_Puesto.Text.Trim());

                obj_BLL_Puesto.Insertar_Puesto(ref obj_DAL_Puesto);

                if ((obj_DAL_Puesto.sMsjError == string.Empty) || (obj_DAL_Puesto.sMsjError == null))
                {
                    MessageBox.Show("Nuevo Empleado registrado con exito...!!!", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Nombre_Puesto.Clear();
                    txt_Funciones_Puesto.Clear();
                    txt_Salario_Puesto.Clear();
                }
                else
                {
                    MessageBox.Show("Nuevo Empleado no ha sido registrado con exito...!!!" + obj_DAL_Puesto.sMsjError, "Creación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                obj_DAL_Puesto.sNombre = "";

                
            }

            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);
        }

      
    }
}


