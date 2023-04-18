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
using DAL.Mantenimiento.Empleados;
using BLL.Mantenimiento.Empleados;
using DAL.Mantenimiento.Incapacidades;
using BLL.Mantenimiento.Incapacidades;


namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Incapacidades_Editar : Form
    {
        public frm_Incapacidades_Editar()
        {
            InitializeComponent();
        }
        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();

        cls_Incapacidades_BLL obj_BLL_Incapacidad = new cls_Incapacidades_BLL();

        public cls_Incapacidades_DAL obj_DAL_Modifica_Incapacidad;

        private void label4_Click(object sender, EventArgs e)
        {

        }

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
                if ((e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)) || (char.IsLetter(e.KeyChar)) || (e.KeyChar) == 44 || (e.KeyChar == (char)Keys.Space))
                {
                   
                        e.Handled = false;                  
                }
                else
                {
                    e.Handled = true;
                }
            }

        }
        #endregion


        #region KeyPress

        private void txt_Contacto_Emer_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Descripcion,e);
        }


        #endregion

        #region CloseUp
        private void dtp_Inicio_Periodo_CloseUp(object sender, EventArgs e)
        {
            obj_DAL.tspDiffDates = DateTime.Now.Subtract(dtp_Inicio_Periodo.Value);

            if (obj_DAL.tspDiffDates.Days > 0)
            {
                MessageBox.Show("La fecha no puede ser menor a la actual.\n" + DateTime.Now.ToString(" dd MM yyyy"), "Fecha erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_Inicio_Periodo.Value = DateTime.Now;
            }
           
        }

        private void dtp_Final_Periodo_CloseUp(object sender, EventArgs e)
        {
            obj_DAL.tspDiffDates = DateTime.Now.Subtract(dtp_Final_Periodo.Value);

            if (obj_DAL.tspDiffDates.TotalDays >= 0) 
            { 
                MessageBox.Show("La fecha debe ser mayor a la actual.\n" + DateTime.Now.ToString(" dd MM yyyy"), "Fecha erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_Final_Periodo.Value = DateTime.Now;
            }
        }


        #endregion

        private void txt_Num_Orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Num_Orden,e);
        }

        private void frm_Incapacidades_Editar_Load(object sender, EventArgs e)
        {
            obj_DAL.sEmpleado_ID = "";
            obj_BLL.Listar_Filtrar_EMPLEADOS(ref obj_DAL);

            cbx_Empleado_modifica.DataSource = obj_DAL.dtDatos;
            cbx_Empleado_modifica.DisplayMember = "Nombre";
            cbx_Empleado_modifica.ValueMember = "Empleado_ID";

            cbx_Empleado_modifica.SelectedValue = obj_DAL_Modifica_Incapacidad.sEmpleado_ID;
            dtp_Inicio_Periodo.Value = obj_DAL_Modifica_Incapacidad.dFecha_Inicio;
            dtp_Final_Periodo.Value = obj_DAL_Modifica_Incapacidad.dFecha_Final;
            txt_Num_Orden.Text = obj_DAL_Modifica_Incapacidad.iNuemro_Orden.ToString();
            txt_Descripcion.Text = obj_DAL_Modifica_Incapacidad.sDescripcion.ToString();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (txt_Num_Orden.Text == "" || txt_Descripcion.Text == "" )
            {
                MessageBox.Show("Verifique que no hayan espacios en blanco.", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);             
            }
            else
            {
                obj_DAL_Modifica_Incapacidad.sEmpleado_ID = cbx_Empleado_modifica.SelectedValue.ToString();
                obj_DAL_Modifica_Incapacidad.dFecha_Inicio = dtp_Inicio_Periodo.Value;
                obj_DAL_Modifica_Incapacidad.dFecha_Final = dtp_Final_Periodo.Value;
                obj_DAL_Modifica_Incapacidad.iNuemro_Orden = Convert.ToInt32(txt_Num_Orden.Text.Trim());
                obj_DAL_Modifica_Incapacidad.sDescripcion = txt_Descripcion.Text.Trim();




                obj_BLL_Incapacidad.Modificar_INCAPACIDADES(ref obj_DAL_Modifica_Incapacidad);

                if ((obj_DAL_Modifica_Incapacidad.sMsjError == string.Empty) || (obj_DAL_Modifica_Incapacidad.sMsjError == null))
                {
                    MessageBox.Show("Incapacidad modificada con exito...!!!", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_DAL_Modifica_Incapacidad.sEmpleado_ID = "";
                }
                else
                {
                    MessageBox.Show("La incapacidad no ha sido modificada con exito...!!!" + obj_DAL_Modifica_Incapacidad.sMsjError, "Modificación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            obj_BLL_Incapacidad.Listar_Filtrar_INCAPACIDADES(ref obj_DAL_Modifica_Incapacidad);
        }
    }
}
