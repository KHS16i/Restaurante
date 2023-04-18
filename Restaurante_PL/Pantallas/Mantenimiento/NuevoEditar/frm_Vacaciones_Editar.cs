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
using DAL.Mantenimiento.Vacaciones;
using BLL.Mantenimiento.Vacaciones;
using BLL.Mantenimiento.Empleados;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Vacaciones_Editar : Form
    {
        public frm_Vacaciones_Editar()
        {
            InitializeComponent();
        }

        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();

        cls_Vacaciones_BLL obj_BLL_Vacaciones = new cls_Vacaciones_BLL();

        public cls_Vacaciones_DAL obj_Modifica_Vacaciones;
        private void frm_Vacaciones_Nuevo_Load(object sender, EventArgs e)
        {
            obj_DAL.sEmpleado_ID = "";
            obj_BLL.Listar_Filtrar_EMPLEADOS(ref obj_DAL);

            comboBox1.DataSource = obj_DAL.dtDatos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Empleado_ID";

            comboBox1.SelectedValue = obj_Modifica_Vacaciones.sEmpleado_ID;
            txt_Dias_Disponibles.Text = obj_Modifica_Vacaciones.dDias_Disponibles.ToString();
            txt_Dias_Nuevo_Periodo.Text = obj_Modifica_Vacaciones.iDias_Tomados.ToString();
            dtp_Fecha_Inicio_Periodo.Value = obj_Modifica_Vacaciones.dFecha_Inicio_Vacaciones;
            
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

        private void Validaciones_Numeros(TextBox txt, KeyPressEventArgs e)
        {
            {

                if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
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

        private void txt_Dias_Nuevo_Periodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Numeros(txt_Dias_Nuevo_Periodo, e);

            Decimal a;
            Decimal.TryParse(txt_Dias_Disponibles.Text.Trim(),out a);

            if (a > (Convert.ToDecimal(txt_Dias_Nuevo_Periodo.Text.Trim())))
            {
                MessageBox.Show("Los días que ha ingresado, excede el disponible.","Días excede el disponible",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_Dias_Nuevo_Periodo.Text = "";
            }

        }

        private void dtp_Fecha_Inicio_Periodo_CloseUp(object sender, EventArgs e)
        {           
            obj_DAL.tspDiffDates = DateTime.Now.Subtract(dtp_Fecha_Inicio_Periodo.Value);

            if (dtp_Fecha_Inicio_Periodo.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser menor a la actual.\n" + DateTime.Now.ToString(" dd MM yyyy") , "Fecha erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_Fecha_Inicio_Periodo.Value = DateTime.Now;
            }
            else
            {
                if (obj_DAL.tspDiffDates.Days < -15)
                {
                    MessageBox.Show("Solo se permite ingresar un periodo que no supere los proximos 15 días, a partir de hoy.\n" + DateTime.Now.ToString(" dd MM yyyy"), "Fecha excede el limite a futuro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtp_Fecha_Inicio_Periodo.Value = DateTime.Now;
                } 
            }

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || txt_Dias_Disponibles.Text == "" || txt_Dias_Nuevo_Periodo.Text == "" || dtp_Fecha_Inicio_Periodo.Value.Day < DateTime.Now.Day
                || (Convert.ToDecimal(txt_Dias_Disponibles.Text.Trim()) < Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim())))
            {
                MessageBox.Show("Verifique que no hayan espacios en blanco.\nVerifique que el correo esté bien escrito.\nVerifique las fechas correspondan a valores permitidos.\nVerigique que haya seleccionado un puesto.", "Espacios en blanco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                obj_Modifica_Vacaciones.sEmpleado_ID = "";
            }
            else
            {
                if (obj_Modifica_Vacaciones.iDias_Tomados > Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim()))
                {
                    obj_Modifica_Vacaciones.iDias_Tomados = obj_Modifica_Vacaciones.iDias_Tomados - Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim());
                }
                else if(obj_Modifica_Vacaciones.iDias_Tomados < Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim()))
                {

                }

                obj_Modifica_Vacaciones.sEmpleado_ID = comboBox1.SelectedValue.ToString();
                obj_Modifica_Vacaciones.dDias_Disponibles = Convert.ToDecimal(txt_Dias_Disponibles.Text.Trim());
                obj_Modifica_Vacaciones.iDias_Tomados = Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim());
                obj_Modifica_Vacaciones.dFecha_Inicio_Vacaciones = dtp_Fecha_Inicio_Periodo.Value;
                

                obj_BLL_Vacaciones.Modificar_Vacaciones(ref obj_Modifica_Vacaciones);

                if ((obj_Modifica_Vacaciones.sMsjError == string.Empty) || (obj_Modifica_Vacaciones.sMsjError == null))
                {
                    MessageBox.Show("Empleado modificado con exito...!!!", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El empleado no ha sido modificado con exito...!!!" + obj_Modifica_Vacaciones.sMsjError, "Modificación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_Modifica_Vacaciones);
        }
    }
}
