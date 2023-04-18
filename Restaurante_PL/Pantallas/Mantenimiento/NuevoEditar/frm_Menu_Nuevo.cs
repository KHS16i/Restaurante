using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Mantenimiento.Platillo;
using DAL.Mantenimiento.Productos;
using BLL.Mantenimiento.Menu;
using BLL.Mantenimiento.Platillo;
using BLL.Mantenimiento.Productos;

namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    public partial class frm_Menu_Nuevo : Form
    {
        public frm_Menu_Nuevo()
        {
            InitializeComponent();
        }

            
        #region VARIABLES

        //public cls_Menu_DAL obj_Menu_DAL_Modify;
        cls_Menu_BLL obj_Menu_BLL = new cls_Menu_BLL();

        cls_Platillo_BLL obj_Platillo_BLL = new cls_Platillo_BLL();
        cls_Platillo_DAL obj_Platillo_DAL = new cls_Platillo_DAL();

        cls_Productos_BLL obj_Productos_BLL = new cls_Productos_BLL();
        cls_Productos_DAL obj_Productos_DAL = new cls_Productos_DAL();
               
        #endregion

        
       public void LoadDataProductos()
       {

           if (txt_buscar_prod_menu.Text == "")
           {
               txt_buscar_prod_menu.Text = "0";
           }

           obj_Productos_DAL.iProductoID = Convert.ToInt32(txt_buscar_prod_menu.Text.Trim());

           obj_Productos_BLL.Listar_Filtrar_Productos_2(ref obj_Productos_DAL);

           if ((obj_Productos_DAL.sMsjError == "") || (obj_Productos_DAL.sMsjError == null))
           {
               dvg_productos_newMenu.DataSource = null;
               dvg_productos_newMenu.DataSource = obj_Productos_DAL.dtDatos;
           }
           else
           {
               MessageBox.Show("Se presentó un error listando los productos. " + obj_Productos_DAL.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
       }




        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
           {
               e.Handled = false;
           }
           else
           {
               e.Handled = true;
           }
       }


       private void frm_Menu_Nuevo_Load(object sender, EventArgs e)
       {
           obj_Platillo_BLL.Listar_Filtrar_Platillo(ref obj_Platillo_DAL);
           cbx_Platillo.DataSource = obj_Platillo_DAL.dtDatos;
           cbx_Platillo.DisplayMember = "Nombre";
           cbx_Platillo.ValueMember = "Platillo_ID";

           //obj_Productos_BLL.Listar_Filtrar_Productos(ref obj_Productos_DAL);
           //dvg_productos_newMenu.DataSource = obj_Productos_DAL.dtDatos;

           txt_Menu_ID.Text = string.Empty;
           //txt_buscar_prod_menu.Text = string.Empty;
           txt_cantidad_prod_menu.Text = string.Empty;

           LoadDataProductos(); // Llamado de listar a DGV Productos

       }


   

       private void txt_Menu_ID_Leave(object sender, EventArgs e)
       {
           lbl_menu_ID.Text = txt_Menu_ID.Text.Trim();
       }

       private void cbx_Platillo_SelectedIndexChanged(object sender, EventArgs e)
       {
           lbl_nombre_menu_platillo.Text = cbx_Platillo.Text.Trim();
       }

       private void txt_Menu_ID_TextChanged(object sender, EventArgs e)
       {
           lbl_menu_ID.Text = txt_Menu_ID.Text.Trim();
       }
       
    }

}
