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
    public partial class frm_Puesto_Editar : Form
    {
        public frm_Puesto_Editar()
        {
            InitializeComponent();
        }

        cls_Puesto_BLL OBJ_BLL = new cls_Puesto_BLL();
        cls_Puesto_DAL OBJ_DAL = new cls_Puesto_DAL();


        public cls_Puesto_DAL obj_DAL_Modifica_Puesto = new cls_Puesto_DAL(); 
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
                    if ( ((e.KeyChar == cCarSep) && (txt.SelectionStart == 0)) ||                   
                    ((e.KeyChar == cCarSep) && (txt.Text.Trim().Contains(cCarSep))) )
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
            Validaciones_Letras(txt_Nombre_Puesto,e);
        }
        private void txt_Funciones_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Funciones_Puesto,e);
        }
        private void txt_Salario_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Numeros(txt_Salario_Puesto,e);
        }


        #endregion

        private void frm_Puesto_Editar_Load(object sender, EventArgs e)
        {
           
            txt_Nombre_Puesto.Text = obj_DAL_Modifica_Puesto.sNombre;
            txt_Funciones_Puesto.Text = obj_DAL_Modifica_Puesto.sFunciones;
            txt_Salario_Puesto.Text = obj_DAL_Modifica_Puesto.dSalario.ToString();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (txt_Nombre_Puesto.Text.Equals("") || txt_Funciones_Puesto.Text.Equals("") || txt_Salario_Puesto.Text.Equals(""))
            {
                MessageBox.Show("Verifique que no hayan espacios en blanco.", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                obj_DAL_Modifica_Puesto.sNombre = "";
            }
            else
            {
               
                obj_DAL_Modifica_Puesto.sNombre = txt_Nombre_Puesto.Text.Trim();
                obj_DAL_Modifica_Puesto.sFunciones = txt_Funciones_Puesto.Text.Trim();
                obj_DAL_Modifica_Puesto.dSalario = Convert.ToDecimal(txt_Salario_Puesto.Text.Trim());
               



                OBJ_BLL.Modificar_Puesto(ref obj_DAL_Modifica_Puesto);

                if ((obj_DAL_Modifica_Puesto.sMsjError == string.Empty) || (obj_DAL_Modifica_Puesto.sMsjError == null))
                {
                    MessageBox.Show("Empleado modificado con exito...!!!", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El empleado no ha sido modificado con exito...!!!" + obj_DAL_Modifica_Puesto.sMsjError, "Modificación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
          
        }
    }

}
