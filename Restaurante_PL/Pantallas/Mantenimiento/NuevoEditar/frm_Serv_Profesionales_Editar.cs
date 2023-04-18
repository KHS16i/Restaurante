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
using DAL.Mantenimiento.Servicios_Profesionales;
using BLL.Mantenimiento.Servicios_Profesionales;
using DAL.Mantenimiento.Puesto;
using BLL.Mantenimiento.Puesto;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Serv_Profesionales_Editar : Form
    {
        public frm_Serv_Profesionales_Editar()
        {
            InitializeComponent();
        }
        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();

        public cls_Servicios_Profesionales_DAL obj_Modifica_Servicios_Profesionales;
        cls_Servicios_Profecionales_BLL obj_Servicios_Profesionales_BLL = new cls_Servicios_Profecionales_BLL();

        cls_Puesto_BLL Obj_Puesto_BLL = new cls_Puesto_BLL();
        cls_Puesto_DAL Obj_Puesto_DAL = new cls_Puesto_DAL();

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            obj_Modifica_Servicios_Profesionales.sServicio_recibido = "";
            obj_Servicios_Profesionales_BLL.Listar_Filtrar_Servicios_Profesionales(ref obj_Modifica_Servicios_Profesionales);



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
            Validaciones_Direccion(txt_ID, e);
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
            Validaciones_Numeros(txt_Monto_Cancelado, e);
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

        private void frm_Serv_Profesionales_Editar_Load(object sender, EventArgs e)
        {
            Obj_Puesto_DAL.sNombre = "";
            Obj_Puesto_BLL.Listar_Filtrar_Puesto(ref Obj_Puesto_DAL);

            cbx_Puestos.DataSource = Obj_Puesto_DAL.dtDatos;
            cbx_Puestos.DisplayMember = "Nombre";
            cbx_Puestos.ValueMember = "Puesto_ID";
            cbx_Puestos.SelectedValue = obj_Modifica_Servicios_Profesionales.iPuesto_ID;

            obj_DAL.sEmpleado_ID = "";
            obj_BLL.Listar_Filtrar_EMPLEADOS(ref obj_DAL);

            cbx_Empleado_Aut.DataSource = obj_DAL.dtDatos;
            cbx_Empleado_Aut.DisplayMember = "Nombre";
            cbx_Empleado_Aut.ValueMember = "Empleado_ID";
            cbx_Empleado_Aut.SelectedValue = obj_Modifica_Servicios_Profesionales.sEmpleado_ID;

            txt_Nombre.Text = obj_Modifica_Servicios_Profesionales.sNombre;
            txt_ID.Text = obj_Modifica_Servicios_Profesionales.sOferente_ID;
            txt_Horas_Laboradas.Text = obj_Modifica_Servicios_Profesionales.iHoras_Laboradas.ToString();
            txt_Serv_Recibido.Text = obj_Modifica_Servicios_Profesionales.sServicio_recibido;
            txt_Monto_Cancelado.Text = obj_Modifica_Servicios_Profesionales._dMonto_Cancelado.ToString();
            dtp_Fecha_Servicio.Value = obj_Modifica_Servicios_Profesionales.dFecha_Servicio;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Equals("") || txt_ID.Equals("") || txt_Horas_Laboradas.Equals("") || txt_Serv_Recibido.Equals("") || txt_Monto_Cancelado.Equals("") )
            {
                MessageBox.Show("Verifique que no hayan espacios en blanco.", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                obj_Modifica_Servicios_Profesionales.sServicio_recibido = "";
            }
            else
            {
                obj_Modifica_Servicios_Profesionales.sNombre = txt_Nombre.Text.Trim();
                obj_Modifica_Servicios_Profesionales.sOferente_ID = txt_ID.Text.Trim();
                obj_Modifica_Servicios_Profesionales.iHoras_Laboradas = Convert.ToInt32(txt_Horas_Laboradas.Text.Trim());
                obj_Modifica_Servicios_Profesionales.sServicio_recibido = txt_Serv_Recibido.Text.Trim();
                obj_Modifica_Servicios_Profesionales._dMonto_Cancelado =Convert.ToDecimal(txt_Monto_Cancelado.Text.Trim());
                obj_Modifica_Servicios_Profesionales.dFecha_Servicio = dtp_Fecha_Servicio.Value;



                obj_Servicios_Profesionales_BLL.Modificar_Servicios_Profesionales(ref obj_Modifica_Servicios_Profesionales);

                if ((obj_Modifica_Servicios_Profesionales.sMsjError == string.Empty) || (obj_Modifica_Servicios_Profesionales.sMsjError == null))
                {
                    MessageBox.Show("Servicio modificado con exito...!!!", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El servicio no ha sido modificado con exito...!!!" + obj_Modifica_Servicios_Profesionales.sMsjError, "Modificación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            obj_Servicios_Profesionales_BLL.Modificar_Servicios_Profesionales(ref obj_Modifica_Servicios_Profesionales);
        }
    }
}
