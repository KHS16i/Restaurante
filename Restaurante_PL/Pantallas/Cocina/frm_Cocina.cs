using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar;
using DAL.Mantenimiento.Menu;
using BLL.Mantenimiento.Menu;


namespace Plantilla_Diseño_2.Pantallas.Cocina
{
    public partial class frm_Cocina : Form
    {

        #region VARIABLES GLOBALES

        frm_Merma_Cocina obj_merma = new frm_Merma_Cocina();
        frm_Menu_Nuevo obj_nuevo_editar_menu = new frm_Menu_Nuevo();

        cls_Menu_DAL obj_Menu_DAL = new cls_Menu_DAL();
        cls_Menu_BLL obj_Menu_BLL = new cls_Menu_BLL();

        #endregion

        #region EVENTOS

        public frm_Cocina()
        {
            InitializeComponent();
        }

        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        private void btn_Main_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Main_max.Visible = false;
            btn_Main_res.Visible = true;
        }

        private void btn_Main_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Main_res_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Main_max.Visible = true;
            btn_Main_res.Visible = false;
        }
   
        private void btn_Home_Click(object sender, EventArgs e)
        {
            tb_Cocina.SelectedIndex = 0;

            btn_Main_Orden.BackColor = Color.Transparent;
            btn_Main_Menu.BackColor = Color.Transparent;
            btn_Main_Mantenimiento.BackColor = Color.Transparent;
        }
               
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar su sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                this.Hide();
                Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
                Obj_Login.ShowDialog();
            }
        }

        private void pn_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region METODOS

        //Para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //fin codigo para mover ventana

        #endregion

        #region METODOS BASES DE DATOS
        
        private void LoadDataMenu()
        {

            if (txt_menu_filtrar.Text == "")
            {
                txt_menu_filtrar.Text = "0";
            }

            obj_Menu_DAL.iMenu_ID = Convert.ToInt32(txt_menu_filtrar.Text.Trim());

            obj_Menu_BLL.Listar_Filtrar_MENU(ref obj_Menu_DAL);

            if ((obj_Menu_DAL.sMsjError == "") || (obj_Menu_DAL.sMsjError == null))
            {
                dgv_cocina_menu.DataSource = null;
                dgv_cocina_menu.DataSource = obj_Menu_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los menus. " + obj_Menu_DAL.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void ModifyData()
        {
            if (dgv_cocina_menu.Rows.Count > 0)
            {
                if (dgv_cocina_menu.SelectedRows[0] != null)
                {
                    obj_Menu_DAL.iMenu_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[0].Value.ToString());
                    obj_Menu_DAL.iPlatillo_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[1].Value.ToString());
                    obj_Menu_DAL.iProducto_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[2].Value.ToString());
                    obj_Menu_DAL.sCantidad = dgv_cocina_menu.SelectedRows[0].Cells[3].Value.ToString();
                                                          
                    obj_nuevo_editar_menu.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No se puede modificar el menú, ya que no tiene un menú seleccionado.\nPor favor seleccione un menú.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar el menú, ya que no tiene un menú disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            LoadDataMenu();

        }

        private void btn_nuevo_menu_Click(object sender, EventArgs e)
        {
            obj_nuevo_editar_menu.ShowDialog();
            
            txt_menu_filtrar.Text = "";
            
            LoadDataMenu();
            
           

        }

        private void btn_modificar_menu_Click(object sender, EventArgs e)
        {
            if (dgv_cocina_menu.Rows.Count > 0)
            {
                if (dgv_cocina_menu.SelectedRows[0] != null)
                {
                    obj_Menu_DAL.iMenu_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[0].Value.ToString());
                    obj_Menu_DAL.iPlatillo_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[1].Value.ToString());
                    obj_Menu_DAL.iProducto_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[2].Value.ToString());
                    obj_Menu_DAL.sCantidad = dgv_cocina_menu.SelectedRows[0].Cells[3].Value.ToString();

                    //obj_Menu_DAL.sAccion = "M";
                    //Pantallas.frm_Nuevo_Mod_Menu obj_Pantalla_Nueva_Modifica = new frm_Nuevo_Mod_Menu();
                    //obj_Pantalla_Nueva_Modifica.obj_Menu_DAL_Modify = obj_Menu_DAL;

                    obj_nuevo_editar_menu.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No se puede modificar el menú, ya que no tiene un menú seleccionado.\nPor favor seleccione un menú.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar el menú, ya que no tiene un menú disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            LoadDataMenu();
        }

        private void btn_eliminar_menu_Click(object sender, EventArgs e)
        {
            if (dgv_cocina_menu.Rows.Count > 0)
            {
                if (dgv_cocina_menu.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Desea eliminar el menú [" + dgv_cocina_menu.SelectedRows[0].Cells[0].Value.ToString()
                        + ", " + dgv_cocina_menu.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + dgv_cocina_menu.SelectedRows[0].Cells[2].Value.ToString().Trim() + "]...???",
                        "¿Seguro que quiere eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj_Menu_DAL.iMenu_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[0].Value.ToString());
                        obj_Menu_DAL.iPlatillo_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[1].Value.ToString());
                        obj_Menu_DAL.iProducto_ID = Convert.ToInt32(dgv_cocina_menu.SelectedRows[0].Cells[2].Value.ToString());
                        obj_Menu_DAL.sCantidad = dgv_cocina_menu.SelectedRows[0].Cells[3].Value.ToString();

                        obj_Menu_BLL.Eliminar_MENU(ref obj_Menu_DAL);

                        if ((obj_Menu_DAL.sMsjError == string.Empty) || (obj_Menu_DAL.sMsjError == null))
                        {
                            MessageBox.Show("Menu [" + dgv_cocina_menu.SelectedRows[0].Cells[0].Value.ToString()
                                            + ", " + dgv_cocina_menu.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + dgv_cocina_menu.SelectedRows[0].Cells[2].Value.ToString().Trim() + "] fue eliminada exitosamente.",
                                            "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_menu_filtrar.Clear();
                            LoadDataMenu();

                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en el borrado del menú seleccionado. " + obj_Menu_DAL.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se puede eliminar ningún menú, ya que no tiene ningún menú seleccionado.\nPor favor seleccione un menú.", "No hay menú seleccionado",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar ningún menú, ya que no hay menú disponibles para eliminar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dgv_cocina_menu_DoubleClick(object sender, EventArgs e)
        {
            ModifyData();
        }

        private void txt_menu_filtrar_TextChanged(object sender, EventArgs e)
        {
            LoadDataMenu();
        }

        private void btn_menu_filtrar_Click(object sender, EventArgs e)
        {
            LoadDataMenu();
        }

        #endregion

        private void btn_Main_Orden_Click(object sender, EventArgs e)
        {
            tb_Cocina.SelectedIndex = 0;
            btn_Main_Orden.BackColor = Color.FromArgb(38, 40, 55);
            btn_Main_Menu.BackColor = Color.Transparent;
            btn_Main_Mantenimiento.BackColor = Color.Transparent;
        }

        private void btn_Main_Menu_Click(object sender, EventArgs e)
        {
            LoadDataMenu();

            tb_Cocina.SelectedIndex = 1;
            btn_Main_Orden.BackColor = Color.Transparent;
            btn_Main_Menu.BackColor = Color.FromArgb(38, 40, 55);
            btn_Main_Mantenimiento.BackColor = Color.Transparent;
        }

        private void btn_Main_Mantenimiento_Click(object sender, EventArgs e)
        {
            tb_Cocina.SelectedIndex = 2;
            btn_Main_Orden.BackColor = Color.Transparent;
            btn_Main_Menu.BackColor = Color.Transparent;
            btn_Main_Mantenimiento.BackColor = Color.FromArgb(38, 40, 55);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            obj_merma.ShowDialog();
        }

    }
}
