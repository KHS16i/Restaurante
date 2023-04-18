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
using DAL.Mantenimiento.Puesto;
using BLL.Mantenimiento.Puesto;
using DAL.BD;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Empleado_Nuevo : Form
    {
        public frm_Empleado_Nuevo()
        {
            InitializeComponent();         
        }

        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();

        cls_Puesto_DAL obj_DAL_Puesto = new cls_Puesto_DAL();
        cls_Puesto_BLL obj_BLL_Puesto = new cls_Puesto_BLL();

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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


        #region KeyPress Events
        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) )
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }

        private void txt_Nombre_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Letras(txt_Nombre_Empleado, e);
        }

        private void mtxt_Telefono_Personal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Masked_Numeros(mtxt_Telefono_Personal,e);
        }

        private void mtxt_Contacto_Emergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Masked_Numeros(mtxt_Contacto_Emergencia, e);
        }
        private void txt_Apellido_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Letras(txt_Apellido_Empleado,e);
        }
        private void txt_Direccion_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Direccion_Empleado,e);
        }

        #endregion

        #region CloseUp

        private void dtp_Fecha_Nacimiento_CloseUp(object sender, EventArgs e)
        {
            obj_DAL.dtmFecha_II = dtp_Fecha_Nacimiento.Value;

            if (obj_DAL.dtmFecha_II > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la de hoy.\n" + obj_DAL.dtmFecha_II.ToString("dd / MM / yyyy"), "Fecha erronea.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                obj_DAL.dtmFecha_II = DateTime.Now;
                dtp_Fecha_Nacimiento.Value = DateTime.Now;
            }
            else
            {
                obj_DAL.tspDiffDates = DateTime.Now.Subtract(obj_DAL.dtmFecha_II);

                if (obj_DAL.tspDiffDates.TotalDays < 6574.0001052394982)
                {
                    MessageBox.Show("La edad de la persona es menor a 18 años, no es permitido por la ley vigente en Costa Rica.\nFecha seleccionada: " + obj_DAL.dtmFecha_II.ToString("dd / MM / yyyy"), "Persona menor de edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    obj_DAL.dtmFecha_II = DateTime.Now;
                    dtp_Fecha_Nacimiento.Value = DateTime.Now;
                }

                obj_DAL.tspDiffDates.Equals("");
            }

        }

        private void dtp_Fecha_Ingreso_CloseUp(object sender, EventArgs e)
        {
            obj_DAL.dtmFecha_II = dtp_Fecha_Ingreso.Value;

            obj_DAL.tspDiffDates = DateTime.Now.Subtract(obj_DAL.dtmFecha_II);

            if ((obj_DAL.tspDiffDates.Days > 2))
            {

                MessageBox.Show("La fecha no puede ser mayor a 2 días antes o despues de la actual.\n" + obj_DAL.dtmFecha_II.ToString("dd / MM / yyyy"), "Fecha excede lo permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                obj_DAL.dtmFecha_II = DateTime.Now;
                dtp_Fecha_Ingreso.Value = DateTime.Now;
            }
            else
            {
                obj_DAL.tspDiffDates = obj_DAL.dtmFecha_II.Subtract(DateTime.Now);
                if ((obj_DAL.tspDiffDates.Days >= 2))
                {

                    MessageBox.Show("La fecha no puede ser mayor a 2 días antes o despues de la actual.\n" + obj_DAL.dtmFecha_II.ToString("dd / MM / yyyy"), "Fecha excede lo permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    obj_DAL.dtmFecha_II = DateTime.Now;
                    dtp_Fecha_Ingreso.Value = DateTime.Now;
                }
            }

            obj_DAL.tspDiffDates.Equals("");
        }

        #endregion

        private void btn_Home_Click(object sender, EventArgs e)
        {
            
            if (txt_ID.Text.Equals("") || txt_Nombre_Empleado.Text.Equals("") || txt_Apellido_Empleado.Text.Equals("") || txt_Direccion_Empleado.Text.Equals("") || mtxt_Telefono_Personal.Text.Equals("") 
                || mtxt_Contacto_Emergencia.Text.Equals("") || dtp_Fecha_Ingreso.Value == DateTime.Now || dtp_Fecha_Nacimiento.Text.Equals(DateTime.Now) || cbx_Puestos.SelectedItem == null || !msk_Correo.Text.Contains('@') || msk_Correo.Text.Equals(""))
            {  
                MessageBox.Show("Verifique que no hayan espacios en blanco.\nVerifique que el correo esté bien escrito.\nVerifique las fechas correspondan a valores permitidos.\nVerigique que haya seleccionado un puesto.","Espacios en blanco",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                obj_DAL.sEmpleado_ID = "";
            }
            else 
            {
                obj_DAL.sEmpleado_ID = txt_ID.Text.Trim();
                obj_DAL.sNombre = txt_Nombre_Empleado.Text.Trim();
                obj_DAL.sApellidos = txt_Apellido_Empleado.Text.Trim();
                obj_DAL.sDireccion = txt_Direccion_Empleado.Text.Trim();
                obj_DAL.sTelefono_Personal = mtxt_Telefono_Personal.Text.Trim();
                obj_DAL.sContacto_Emergencia = mtxt_Contacto_Emergencia.Text.Trim();
                obj_DAL.sCorreo = msk_Correo.Text.Trim();
                obj_DAL.dFecha_Nacimiento = dtp_Fecha_Nacimiento.Value;
                obj_DAL.dFecha_Ingreso = dtp_Fecha_Ingreso.Value;
                obj_DAL.iPuesto_ID = Convert.ToInt32(cbx_Puestos.SelectedIndex.ToString());


                obj_BLL.Insertar_EMPLEADOS(ref obj_DAL);


                if ((obj_DAL.sMsjError == string.Empty) || (obj_DAL.sMsjError == null))
                {
                    MessageBox.Show("Nuevo Empleado registrado con exito...!!!", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_ID.Clear();
                    txt_Nombre_Empleado.Clear();
                    txt_Apellido_Empleado.Clear();
                    txt_Direccion_Empleado.Clear();
                    mtxt_Telefono_Personal.Clear();
                    mtxt_Contacto_Emergencia.Clear();
                    msk_Correo.Clear();
                    dtp_Fecha_Nacimiento.Value = DateTime.Now;
                    dtp_Fecha_Ingreso.Value = DateTime.Now;
                    cbx_Puestos.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Nuevo Empleado no ha sido registrado con exito...!!!" + obj_DAL.sMsjError, "Creación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                obj_DAL.sEmpleado_ID = "";
            }

            obj_BLL.Listar_Filtrar_EMPLEADOS(ref obj_DAL);
            
            
        }

        private void frm_Empleado_Nuevo_Load(object sender, EventArgs e)
        {
            obj_DAL_Puesto.sNombre = "";
            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);

            cbx_Puestos.DataSource = obj_DAL_Puesto.dtDatos;
            cbx_Puestos.DisplayMember = "Nombre";
            cbx_Puestos.ValueMember = "Puesto_ID";
            cbx_Puestos.SelectedIndex = -1;
            
        }

        private void cbx_Puestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
