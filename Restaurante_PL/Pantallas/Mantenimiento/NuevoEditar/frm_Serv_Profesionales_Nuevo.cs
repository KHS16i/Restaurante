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
using DAL.Mantenimiento.Servicios_Profesionales;
using BLL.Mantenimiento.Servicios_Profesionales;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Serv_Profesionales_Nuevo : Form
    {
        public frm_Serv_Profesionales_Nuevo()
        {
            InitializeComponent();
        }

        #region Clases

        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();

        cls_Puesto_DAL obj_DAL_Puesto = new cls_Puesto_DAL();
        cls_Puesto_BLL obj_BLL_Puesto = new cls_Puesto_BLL();

        cls_Servicios_Profesionales_DAL obj_DAL_Servicios_Profesionales = new cls_Servicios_Profesionales_DAL();
        cls_Servicios_Profecionales_BLL obj_BLL_Servicios_Profesionales = new cls_Servicios_Profecionales_BLL();

        #endregion


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
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Letras(txt_Nombre, e);
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Horas_Laboradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Numeros(txt_Horas_Laboradas, e);
        }

        private void txt_Serv_Recibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Direccion(txt_Serv_Recibido, e);
        }

        private void txt_Monto_Cancelado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        private void dtp_Fecha_Servicio_CloseUp(object sender, EventArgs e)
        {
            {
                obj_DAL.tspDiffDates = DateTime.Now.Subtract(dtp_Fecha_Servicio.Value);

                if ((obj_DAL.tspDiffDates.Days > 2))
                {

                    MessageBox.Show("La fecha no puede ser mayor a 2 días antes o despues de la actual.\n" + DateTime.Now.ToString("dd / MM / yyyy"), "Fecha excede lo permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtp_Fecha_Servicio.Value = DateTime.Now;

                }
                else
                {
                    obj_DAL.tspDiffDates = dtp_Fecha_Servicio.Value.Subtract(DateTime.Now);
                    if ((obj_DAL.tspDiffDates.Days >= 2))
                    {

                        MessageBox.Show("La fecha no puede ser mayor a 2 días antes o despues de la actual.\n" + DateTime.Now.ToString("dd / MM / yyyy"), "Fecha excede lo permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtp_Fecha_Servicio.Value = DateTime.Now;

                    }
                }

                obj_DAL.tspDiffDates.Equals("");
            }
        }

        private void frm_Serv_Profesionales_Nuevo_Load(object sender, EventArgs e)
        {
            //Carga combo Empleados
            obj_DAL.sEmpleado_ID = "";

            obj_BLL.Listar_Filtrar_EMPLEADOS(ref  obj_DAL);

            cbx_Empleado_Aut.DataSource = obj_DAL.dtDatos;
            cbx_Empleado_Aut.DisplayMember = "Nombre";
            cbx_Empleado_Aut.ValueMember = "Empleado_ID";

            //Carga combo Puestos
            obj_DAL_Puesto.sNombre = "";

            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);
            cbx_Puestos.DataSource = obj_DAL_Puesto.dtDatos;
            cbx_Puestos.DisplayMember = "Nombre";
            cbx_Puestos.ValueMember = "Puesto_ID";
           
        }

        private void cbx_Empleado_Aut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbx_Puestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "" || txt_ID.Text == "" || txt_Horas_Laboradas.Text == "" || cbx_Empleado_Aut.SelectedIndex == -1 || txt_Serv_Recibido.Text == "" || txt_Monto_Cancelado.Text == "" 
                || cbx_Puestos.SelectedIndex == -1)
            {
                MessageBox.Show("No puede dejar espacios en blanco.", "¡Espacios en blanco!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                obj_DAL_Servicios_Profesionales.sNombre = txt_Nombre.Text.Trim();
                obj_DAL_Servicios_Profesionales.sOferente_ID = txt_ID.Text.Trim();
                obj_DAL_Servicios_Profesionales.iHoras_Laboradas = Convert.ToInt32(txt_Horas_Laboradas.Text.Trim());
                obj_DAL_Servicios_Profesionales.sEmpleado_ID = cbx_Empleado_Aut.SelectedValue.ToString();
                obj_DAL_Servicios_Profesionales.sServicio_recibido = txt_Serv_Recibido.Text.Trim();
                obj_DAL_Servicios_Profesionales.dMonto_Cancelado = Convert.ToDecimal(txt_Monto_Cancelado.Text.Trim());
                obj_DAL_Servicios_Profesionales.dFecha_Servicio = dtp_Fecha_Servicio.Value;
                obj_DAL_Servicios_Profesionales.iPuesto_ID = Convert.ToInt32(cbx_Puestos.SelectedValue);
                

                obj_BLL_Servicios_Profesionales.Insertar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);

                if ((obj_DAL_Servicios_Profesionales.sMsjError == string.Empty) || (obj_DAL_Servicios_Profesionales.sMsjError == null))
                {
                    MessageBox.Show("Nuevo servicio profesional registrado con exito...!!!", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Nombre.Clear();
                    txt_ID.Clear();
                    txt_Horas_Laboradas.Clear();
                    cbx_Empleado_Aut.SelectedIndex = -1;
                    txt_Serv_Recibido.Clear();
                    txt_Monto_Cancelado.Clear();
                    dtp_Fecha_Servicio.Value = DateTime.Now;
                    cbx_Puestos.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Nuevo servicio profesional NO ha sido registrado con exito...!!!" + obj_DAL.sMsjError, "Creación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                obj_DAL_Servicios_Profesionales.sServicio_recibido = "";
            }
         
        }
    }
}
