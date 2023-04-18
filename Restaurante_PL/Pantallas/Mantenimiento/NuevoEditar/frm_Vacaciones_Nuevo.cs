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
using BLL.Mantenimiento.Vacaciones;
using DAL.Mantenimiento.Vacaciones;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Vacaciones_Nuevo : Form
    {
        public frm_Vacaciones_Nuevo()
        {
            InitializeComponent();
        }

        cls_Empleados_DAL obj_DAL = new cls_Empleados_DAL();
        cls_Empleados_BLL obj_BLL = new cls_Empleados_BLL();
        cls_Vacaciones_BLL obj_BLL_Vacaciones = new cls_Vacaciones_BLL();
        cls_Vacaciones_DAL obj_DAL_Vacaciones = new cls_Vacaciones_DAL();


        private void frm_Vacaciones_Nuevo_Load(object sender, EventArgs e)
        {
            obj_DAL.sEmpleado_ID = "";
            obj_BLL.Listar_Filtrar_EMPLEADOS(ref obj_DAL);

            comboBox1.DataSource = obj_DAL.dtDatos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Empleado_ID";
            comboBox1.SelectedIndex = -1;


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

                if ((char.IsNumber(e.KeyChar) && e.KeyChar != 0) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 0 && txt.SelectionStart == 0))
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

            
          

        }

        private void dtp_Fecha_Inicio_Periodo_CloseUp(object sender, EventArgs e)
        {
            obj_DAL.tspDiffDates = DateTime.Now.Subtract(dtp_Fecha_Inicio_Periodo.Value);

            if (dtp_Fecha_Inicio_Periodo.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser menor a la actual.\n" + DateTime.Now.ToString(" dd MM yyyy"), "Fecha erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Verifique lo siguiente:\n" +
                    "- Que no haya espacios en blanco.\n" +
                    "- Que los días del nuevo periodo no sean mayor a los disponibles.\n" +
                    "- Que haya seleccionado al menos un empleado.\n" +
                    "- Que la fecha no sea menor a hoy.", "Espacios no permitidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                obj_DAL_Vacaciones.sEmpleado_ID = comboBox1.SelectedValue.ToString();
                obj_DAL_Vacaciones.dDias_Disponibles = Convert.ToDecimal(txt_Dias_Disponibles.Text);
                obj_DAL_Vacaciones.iDias_Tomados = Convert.ToInt32(txt_Dias_Nuevo_Periodo.Text.Trim());
                obj_DAL_Vacaciones.dFecha_Inicio_Vacaciones = dtp_Fecha_Inicio_Periodo.Value;


                obj_BLL_Vacaciones.Insertar_Vacaciones(ref obj_DAL_Vacaciones);


                if ((obj_DAL_Vacaciones.sMsjError == string.Empty) || (obj_DAL_Vacaciones.sMsjError == null))
                {
                    MessageBox.Show("Nuevo Periodo registrado con exito...!!!", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboBox1.SelectedIndex = -1;
                    txt_Dias_Disponibles.Clear();
                    txt_Dias_Nuevo_Periodo.Clear();
                    dtp_Fecha_Inicio_Periodo.Value = DateTime.Now;

                }
                else
                {
                    MessageBox.Show("Nuevo Empleado no ha sido registrado con exito...!!!" + obj_DAL.sMsjError, "Creación NO Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                obj_DAL_Vacaciones.iVacaciones_ID = 0;
            }

            obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);
        }





        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Dias_Disponibles.Clear();
            //Filtra Vacaciones por ID para obtener días disponibles
            obj_DAL_Vacaciones.sEmpleado_ID = comboBox1.SelectedValue.ToString();
            obj_BLL_Vacaciones.Listar_Vacaciones_Disponibles_EXIST(ref obj_DAL_Vacaciones);





            DataRow[] foundRows;
            string expression = "";
            foundRows = obj_DAL_Vacaciones.dtDatos.Select(expression);
            for (int i = 0; i < foundRows.Length; i++)
            {
                txt_Dias_Disponibles.Text = foundRows[i][1].ToString();
            }

            if (txt_Dias_Disponibles.Text == "")
            {
                obj_BLL_Vacaciones.Listar_Vacaciones_Disponibles_NO_EXIST(ref obj_DAL_Vacaciones);
                foundRows = obj_DAL_Vacaciones.dtDatos.Select(expression);
                for (int i = 0; i < foundRows.Length; i++)
                {
                    txt_Dias_Disponibles.Text = foundRows[i][1].ToString();
                }
            }




        }

       
    }

}




