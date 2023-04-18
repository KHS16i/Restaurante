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
using Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar;
using System.Text.RegularExpressions;
using DAL.BD;
using BLL.BD;
using BLL.Mantenimiento.Empleados;
using DAL.Mantenimiento.Empleados;
using BLL.Mantenimiento.Puesto;
using DAL.Mantenimiento.Puesto;
using BLL.Mantenimiento.Vacaciones;
using DAL.Mantenimiento.Vacaciones;
using BLL.Mantenimiento.Servicios_Profesionales;
using DAL.Mantenimiento.Servicios_Profesionales;
using BLL.Mantenimiento.Incapacidades;
using DAL.Mantenimiento.Incapacidades;
using DAL.Mantenimiento.Productos;
using BLL.Mantenimiento.Productos;
using DAL.Mantenimiento.Platillo;
using BLL.Mantenimiento.Platillo;
using DAL.Mantenimiento.Factura;
using BLL.Mantenimiento.Factura;
using DAL.Mantenimiento.Metodo_Pago;
using BLL.Mantenimiento.Metodo_Pago;


namespace Plantilla_Diseño_2.Pantallas.Administracion
{
    public partial class frm_administracion : Form
    {
        #region OBJETOS DE PANTALLAS 
        frm_catProductos_nuevo obj_catProducto_frm = new frm_catProductos_nuevo();
        frm_catProductos_editar obj_catProducto_Editar = new frm_catProductos_editar();
        frm_Menajes_Nuevo obj_menajes_frm = new frm_Menajes_Nuevo();
        frm_Menu_Nuevo obj_menu_frm = new frm_Menu_Nuevo();
        frm_MetodoPago_Nuevo obj_metPagos_frm = new frm_MetodoPago_Nuevo();
        frm_Producto_Nuevo obj_producto_frm = new frm_Producto_Nuevo();
        frm_Proveedor_Nuevo obj_proveedor_frm = new frm_Proveedor_Nuevo();
        frm_TipoComanda_Nuevo obj_tipoComanda_frm = new frm_TipoComanda_Nuevo();
        #endregion

        #region OBJETOS DE CLASES BLL Y DAL

        #region NOMINA
        cls_BD_DAL obj_DAL_DB = new cls_BD_DAL();

        cls_Empleados_BLL obj_BLL_Empleado = new cls_Empleados_BLL();
        cls_Empleados_DAL obj_DAL_Empleado = new cls_Empleados_DAL();

        cls_Puesto_BLL obj_BLL_Puesto = new cls_Puesto_BLL();
        cls_Puesto_DAL obj_DAL_Puesto = new cls_Puesto_DAL();

        cls_Vacaciones_BLL obj_BLL_Vacaciones = new cls_Vacaciones_BLL();
        cls_Vacaciones_DAL obj_DAL_Vacaciones = new cls_Vacaciones_DAL();

        cls_Servicios_Profecionales_BLL obj_BLL_Servicios_Profesionales = new cls_Servicios_Profecionales_BLL();
        cls_Servicios_Profesionales_DAL obj_DAL_Servicios_Profesionales = new cls_Servicios_Profesionales_DAL();

        cls_Incapacidades_BLL obj_BLL_Incapacidades = new cls_Incapacidades_BLL();
        cls_Incapacidades_DAL obj_DAL_Incapacidades = new cls_Incapacidades_DAL();
        #endregion

        #region REPORTES

        #endregion

        #region VENTAS

        #region FACTURACION

        double subtotal;
        double impuesto;
        double propina;
        double descuento;
        double cargoXservicio;
        double total;

        cls_Factura_DAL obj_factura_DAL = new cls_Factura_DAL();
        cls_Factura_BLL obj_factura_BLL = new cls_Factura_BLL();

        cls_Metodo_Pago_DAL obj_metPago_DAL = new cls_Metodo_Pago_DAL();
        cls_Metodo_Pago_BLL obj_metPago_BLL = new cls_Metodo_Pago_BLL();


        #endregion

        #endregion

        #region MANTENIMIENTO

        cls_Productos_DAL obj_productos_DAL = new cls_Productos_DAL();
        cls_Productos_BLL obj_productos_BLL = new cls_Productos_BLL();

        cls_Platillo_DAL obj_platillo_DAL = new cls_Platillo_DAL();
        cls_Platillo_BLL obj_platillo_BLL = new cls_Platillo_BLL();


        #endregion

        #endregion

        public frm_administracion()
        {
            InitializeComponent();
        }



        private void btn_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Main_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Main_max.Visible = false;
            btn_Main_res.Visible = true;
        }

        private void btn_Main_res_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Main_max.Visible = true;
            btn_Main_res.Visible = false;
        }

        #region COLORES


        private void btn_CatPlatillo_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 0;
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);

        }

        private void btn_CatProducto_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 0;
            btn_CatProducto.BackColor = Color.Goldenrod;

            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Menajes_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 1;
            btn_Menajes.BackColor = Color.Goldenrod;

            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 2;
            btn_Menu.BackColor = Color.Goldenrod;

            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_MetodosPagos_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 3;
            btn_MetodosPagos.BackColor = Color.Goldenrod;

            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Platillos_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 4;
            btn_Platillos.BackColor = Color.Goldenrod;

            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 5;
            btn_Productos.BackColor = Color.Goldenrod;

            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 6;
            btn_Proveedores.BackColor = Color.Goldenrod;

            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
            btn_TipoComanda.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_TipoComanda_Click(object sender, EventArgs e)
        {
            tb_Mantenimiento2.SelectedIndex = 7;
            btn_TipoComanda.BackColor = Color.Goldenrod;

            btn_Proveedores.BackColor = Color.FromArgb(31, 29, 44);
            btn_Platillos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menajes.BackColor = Color.FromArgb(31, 29, 44);
            btn_Menu.BackColor = Color.FromArgb(31, 29, 44);
            btn_CatProducto.BackColor = Color.FromArgb(31, 29, 44);
            btn_MetodosPagos.BackColor = Color.FromArgb(31, 29, 44);
            btn_Productos.BackColor = Color.FromArgb(31, 29, 44);
        }
        #endregion

        #region COLORES BOTONES

        private void btn_nomina_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 0;
            btn_nomina.BackColor = Color.Goldenrod;

            btn_mantenimiento.BackColor = Color.Transparent;
            btn_seguridad.BackColor = Color.Transparent;
            btn_reportes.BackColor = Color.Transparent;
            btn_ventas.BackColor = Color.Transparent;
        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 1;
            btn_seguridad.BackColor = Color.Goldenrod;

            btn_mantenimiento.BackColor = Color.Transparent;
            btn_nomina.BackColor = Color.Transparent;
            btn_reportes.BackColor = Color.Transparent;
            btn_ventas.BackColor = Color.Transparent;
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 2;
            btn_reportes.BackColor = Color.Goldenrod;

            btn_mantenimiento.BackColor = Color.Transparent;
            btn_nomina.BackColor = Color.Transparent;
            btn_seguridad.BackColor = Color.Transparent;
            btn_ventas.BackColor = Color.Transparent;
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 3;
            btn_ventas.BackColor = Color.Goldenrod;

            btn_mantenimiento.BackColor = Color.Transparent;
            btn_nomina.BackColor = Color.Transparent;
            btn_reportes.BackColor = Color.Transparent;
            btn_seguridad.BackColor = Color.Transparent;
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 4;
            btn_mantenimiento.BackColor = Color.Goldenrod;

            btn_nomina.BackColor = Color.Transparent;
            btn_seguridad.BackColor = Color.Transparent;
            btn_reportes.BackColor = Color.Transparent;
            btn_ventas.BackColor = Color.Transparent;

        }
        #endregion

        #region NUEVO LISTAR

        private void button39_Click(object sender, EventArgs e)
        {
            obj_catProducto_frm.ShowDialog();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            obj_catProducto_Editar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            obj_menajes_frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Menajes_Editar b = new frm_Menajes_Editar();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj_menu_frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Menu_Editar a = new frm_Menu_Editar();
            a.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            obj_metPagos_frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_MetodoPago_Editar a = new frm_MetodoPago_Editar();
            a.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)//Boton nuevo platillo
        {
            obj_platillo_DAL.sNombre = string.Empty;
            obj_platillo_DAL.dPrecio_Con_IVA = 00;
            obj_platillo_DAL.cOperacion = 'I';

            Pantallas.Mantenimiento.NuevoEditar.frm_Platillo_Nuevo Pant_Edit_Platillo = new frm_Platillo_Nuevo();
            Pant_Edit_Platillo.Obj_Edit_DAL = obj_platillo_DAL;
            Pant_Edit_Platillo.ShowDialog();

            cargarDatosPlatillos();
        }

        private void button21_Click(object sender, EventArgs e)//Boton editar platillo
        {
            editarPlatilloSeleccionado();
            cargarDatosPlatillos();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            obj_producto_frm.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Producto_Editar a = new frm_Producto_Editar();
            a.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            obj_proveedor_frm.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Proveedor_Editar a = new frm_Proveedor_Editar();
            a.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            obj_tipoComanda_frm.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_TipoComanda_Editar a = new frm_TipoComanda_Editar();
            a.ShowDialog();
        }
        #endregion

        #region Botones Nomina

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            tab_Admin_Nomina.SelectedIndex = 1;
            btn_Empleados.BackColor = Color.Goldenrod;
            btn_Vacaciones.BackColor = Color.FromArgb(31, 29, 44);
            btn_Incapacidad.BackColor = Color.FromArgb(31, 29, 44);
            btn_Serv_Profesionales.BackColor = Color.FromArgb(31, 29, 44);
            btn_Puestos.BackColor = Color.FromArgb(31, 29, 44);

            obj_DAL_Empleado.sEmpleado_ID = "";
            obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);
            dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;

        }

        private void btn_Puestos_Click(object sender, EventArgs e)
        {
            tab_Admin_Nomina.SelectedIndex = 2;
            btn_Puestos.BackColor = Color.Goldenrod;
            btn_Vacaciones.BackColor = Color.FromArgb(31, 29, 44);
            btn_Incapacidad.BackColor = Color.FromArgb(31, 29, 44);
            btn_Serv_Profesionales.BackColor = Color.FromArgb(31, 29, 44);
            btn_Empleados.BackColor = Color.FromArgb(31, 29, 44);

            obj_DAL_Puesto.sNombre = "";
            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);
            dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
        }

        private void btn_Vacaciones_Click(object sender, EventArgs e)
        {
            tab_Admin_Nomina.SelectedIndex = 3;
            btn_Vacaciones.BackColor = Color.Goldenrod;
            btn_Incapacidad.BackColor = Color.FromArgb(31, 29, 44);
            btn_Serv_Profesionales.BackColor = Color.FromArgb(31, 29, 44);
            btn_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Puestos.BackColor = Color.FromArgb(31, 29, 44);

            obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);
            dataGridView14.DataSource = obj_DAL_Vacaciones.dtDatos;
        }

        private void btn_Serv_Profesionales_Click(object sender, EventArgs e)
        {
            tab_Admin_Nomina.SelectedIndex = 4;
            btn_Serv_Profesionales.BackColor = Color.Goldenrod;
            btn_Vacaciones.BackColor = Color.FromArgb(31, 29, 44);
            btn_Incapacidad.BackColor = Color.FromArgb(31, 29, 44);
            btn_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Puestos.BackColor = Color.FromArgb(31, 29, 44);

            obj_DAL_Servicios_Profesionales.sServicio_recibido = "";
            obj_BLL_Servicios_Profesionales.Listar_Filtrar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);
            dgv_Serv_Profesionales.DataSource = obj_DAL_Servicios_Profesionales.dtDatos;
        }

        private void btn_Incapacidad_Click(object sender, EventArgs e)
        {
            tab_Admin_Nomina.SelectedIndex = 5;
            btn_Incapacidad.BackColor = Color.Goldenrod;
            btn_Vacaciones.BackColor = Color.FromArgb(31, 29, 44);
            btn_Serv_Profesionales.BackColor = Color.FromArgb(31, 29, 44);
            btn_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Puestos.BackColor = Color.FromArgb(31, 29, 44);

            obj_DAL_Incapacidades.sEmpleado_ID = "";
            obj_BLL_Incapacidades.Listar_Filtrar_INCAPACIDADES(ref obj_DAL_Incapacidades);
            dataGridView3.DataSource = obj_DAL_Incapacidades.dtDatos;
        }

        #endregion


        private void button53_Click(object sender, EventArgs e)
        {
            tb_ventas2.SelectedIndex = 0;
            btn_ventas_facturacion.BackColor = Color.Goldenrod;
            btn_ventas_salon.BackColor = Color.FromArgb(38, 40, 55);
            btn_ventas_cocina.BackColor = Color.FromArgb(38, 40, 55);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            tb_ventas2.SelectedIndex = 1;
            btn_ventas_salon.BackColor = Color.Goldenrod;
            btn_ventas_facturacion.BackColor = Color.FromArgb(38, 40, 55);
            btn_ventas_cocina.BackColor = Color.FromArgb(38, 40, 55);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            tb_ventas2.SelectedIndex = 2;
            btn_ventas_cocina.BackColor = Color.Goldenrod;
            btn_ventas_facturacion.BackColor = Color.FromArgb(38, 40, 55);
            btn_ventas_salon.BackColor = Color.FromArgb(38, 40, 55);
        }

        #region MESAS VERDE

        private void btn_v_mesa_I_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #1".ToString();
            btn_v_mesa_I.Visible = false;
            btn_r_mesa_I.Visible = true;
            btn_cobrar_mesa1_No_Disp.Visible = true;
        }

        private void btn_v_mesa_II_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #2".ToString();
            btn_v_mesa_II.Visible = false;
            btn_r_mesa_II.Visible = true;
            btn_cobrar_mesa2_No_Disp.Visible = true;
        }

        private void btn_v_mesa_III_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #3".ToString();
            btn_v_mesa_III.Visible = false;
            btn_r_mesa_III.Visible = true;
            btn_cobrar_mesa3_No_Disp.Visible = true;
        }

        private void btn_v_mesa_IV_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #4".ToString();
            btn_v_mesa_IV.Visible = false;
            btn_r_mesa_IV.Visible = true;
            btn_cobrar_mesa4_No_Disp.Visible = true;
        }

        private void btn_v_mesa_V_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #5".ToString();
            btn_v_mesa_V.Visible = false;
            btn_r_mesa_V.Visible = true;
            btn_cobrar_mesa5_No_Disp.Visible = true;
        }

        private void btn_v_mesa_VI_Click(object sender, EventArgs e)
        {

            btn_v_mesa_VI.Visible = false;
            btn_r_mesa_VI.Visible = true;
            btn_cobrar_mesa6_No_Disp.Visible = true;
        }

        private void btn_v_mesa_VII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VII.Visible = false;
            btn_r_mesa_VII.Visible = true;
            btn_cobrar_mesa7_No_Disp.Visible = true;
        }

        private void btn_v_mesa_VIII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VIII.Visible = false;
            btn_r_mesa_VIII.Visible = true;
            btn_cobrar_mesa8_No_Disp.Visible = true;
        }

        private void btn_v_mesa_IX_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IX.Visible = false;
            btn_r_mesa_IX.Visible = true;
            btn_cobrar_mesa9_No_Disp.Visible = true;
        }

        private void btn_v_mesa_X_Click(object sender, EventArgs e)
        {
            btn_v_mesa_X.Visible = false;
            btn_r_mesa_X.Visible = true;
            btn_cobrar_mesa10_No_Disp.Visible = true;
        }

        #endregion

        #region MESAS ROJO

        private void btn_r_mesa_I_Click(object sender, EventArgs e)
        {
            btn_v_mesa_I.Visible = true;
            btn_r_mesa_I.Visible = false;
            btn_cobrar_mesa1_No_Disp.Visible = false;
        }
        private void btn_r_mesa_II_Click(object sender, EventArgs e)
        {
            btn_v_mesa_II.Visible = true;
            btn_r_mesa_II.Visible = false;
            btn_cobrar_mesa2_No_Disp.Visible = false;
        }

        private void btn_r_mesa_III_Click(object sender, EventArgs e)
        {
            btn_v_mesa_III.Visible = true;
            btn_r_mesa_III.Visible = false;
            btn_cobrar_mesa3_No_Disp.Visible = false;
        }

        private void btn_r_mesa_IV_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IV.Visible = true;
            btn_r_mesa_IV.Visible = false;
            btn_cobrar_mesa4_No_Disp.Visible = false;
        }

        private void btn_r_mesa_V_Click(object sender, EventArgs e)
        {
            btn_v_mesa_V.Visible = true;
            btn_r_mesa_V.Visible = false;
            btn_cobrar_mesa5_No_Disp.Visible = false;
        }

        private void btn_r_mesa_VI_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VI.Visible = true;
            btn_r_mesa_VI.Visible = false;
            btn_cobrar_mesa6_No_Disp.Visible = false;
        }

        private void btn_r_mesa_VII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VII.Visible = true;
            btn_r_mesa_VII.Visible = false;
            btn_cobrar_mesa7_No_Disp.Visible = false;
        }

        private void btn_r_mesa_VIII_Click(object sender, EventArgs e)
        {
            btn_v_mesa_VIII.Visible = true;
            btn_r_mesa_VIII.Visible = false;
            btn_cobrar_mesa8_No_Disp.Visible = false;
        }

        private void btn_r_mesa_IX_Click(object sender, EventArgs e)
        {
            btn_v_mesa_IX.Visible = true;
            btn_r_mesa_IX.Visible = false;
            btn_cobrar_mesa9_No_Disp.Visible = false;
        }

        private void btn_r_mesa_X_Click(object sender, EventArgs e)
        {
            btn_v_mesa_X.Visible = true;
            btn_r_mesa_X.Visible = false;
            btn_cobrar_mesa10_No_Disp.Visible = false;
        }

        #endregion


        private void btn_Home_Click(object sender, EventArgs e)
        {
            tb_administracion.SelectedIndex = 0;
        }

        private void btn_express_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 2;
        }

        private void btn_VentasxD_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 0;
            btn_VentasxD.BackColor = Color.Goldenrod;

            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_VentasxA_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 1;
            btn_VentasxA.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Reporte_Empleados_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 2;
            btn_Reporte_Empleados.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Reporte_InventarioMenaje_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 3;
            btn_Reporte_InventarioMenaje.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Inventario_Producto_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 4;
            btn_Inventario_Producto.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }



        private void btn_ServiciosPro_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 5;
            btn_ServiciosPro.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Merma_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 6;
            btn_Merma.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma2.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_Merma2_Click(object sender, EventArgs e)
        {
            tab_reportes1.SelectedIndex = 7;
            btn_Merma2.BackColor = Color.Goldenrod;

            btn_VentasxD.BackColor = Color.FromArgb(31, 29, 44);
            btn_VentasxA.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_Empleados.BackColor = Color.FromArgb(31, 29, 44);
            btn_Reporte_InventarioMenaje.BackColor = Color.FromArgb(31, 29, 44);
            btn_Inventario_Producto.BackColor = Color.FromArgb(31, 29, 44);
            btn_ServiciosPro.BackColor = Color.FromArgb(31, 29, 44);
            btn_Merma.BackColor = Color.FromArgb(31, 29, 44);
        }

        private void btn_orden_mesa_I_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #1".ToString();
        }

        private void btn_orden_mesa_II_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #2".ToString();
        }

        private void btn_orden_mesa_III_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #3".ToString();
        }

        private void btn_orden_mesa_IV_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #4".ToString();
        }

        private void btn_orden_mesa_V_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #5".ToString();
        }

        private void btn_orden_mesa_VI_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #6".ToString();
        }

        private void btn_orden_mesa_VII_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #7".ToString();
        }

        private void btn_orden_mesa_VIII_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #8".ToString();
        }

        private void btn_orden_mesa_IX_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #9".ToString();
        }

        private void btn_orden_mesa_X_Click(object sender, EventArgs e)
        {
            tab_crear_orden.SelectedIndex = 1;
            lbl_num_mesa.Text = "Orden: Mesa #10".ToString();
        }



        private void btn_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar su sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Pantallas.Login.frm_Login Obj_Login = new Login.frm_Login();
                Obj_Login.ShowDialog();
            }
        }

        private void btn_Nueva_Incapacidad_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Incapacidades_Nuevo PantIncapacidad = new frm_Incapacidades_Nuevo();
            PantIncapacidad.ShowDialog();

            if (obj_DAL_Incapacidades.sMsjError == "" || obj_DAL_Incapacidades.sMsjError == null)
            {
                obj_BLL_Incapacidades.Listar_Filtrar_INCAPACIDADES(ref obj_DAL_Incapacidades);
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = obj_DAL_Incapacidades.dtDatos;
            }


        }

        private void button44_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Serv_Profesionales_Nuevo PantSerPro = new frm_Serv_Profesionales_Nuevo();
            PantSerPro.ShowDialog();

            obj_DAL_Servicios_Profesionales.sServicio_recibido = string.Empty;

            obj_BLL_Servicios_Profesionales.Listar_Filtrar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);
            dgv_Serv_Profesionales.DataSource = obj_DAL_Servicios_Profesionales.dtDatos;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Empleado_Nuevo PantSerPro = new frm_Empleado_Nuevo();
            PantSerPro.ShowDialog();

            if (obj_DAL_Empleado.sMsjError == "" || obj_DAL_Empleado.sMsjError == null)
            {
                obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);
                dataGridView12.DataSource = null;
                dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;
            }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Puesto_Nuevo PantSerPro = new frm_Puesto_Nuevo();
            PantSerPro.ShowDialog();

            if (obj_DAL_Puesto.sMsjError == "" || obj_DAL_Puesto.sMsjError == null)
            {
                obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);
                dataGridView13.DataSource = null;
                dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.NuevoEditar.frm_Vacaciones_Nuevo PantSerPro = new frm_Vacaciones_Nuevo();
            PantSerPro.ShowDialog();

            if (obj_DAL_Vacaciones.sMsjError == "" || obj_DAL_Vacaciones.sMsjError == null)
            {
                obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);
                dataGridView14.DataSource = null;
                dataGridView14.DataSource = obj_DAL_Vacaciones.dtDatos;
            }
        }

        private void btn_Modifica_Incapacidad_Click(object sender, EventArgs e)
        {

            if (dataGridView3.Rows.Count > 0)
            {
                if (dataGridView3.SelectedRows[0] != null)
                {
                    obj_DAL_Incapacidades.iIncapacidad_ID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
                    obj_DAL_Incapacidades.sEmpleado_ID = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                    obj_DAL_Incapacidades.dFecha_Inicio = Convert.ToDateTime(dataGridView3.SelectedRows[0].Cells[2].Value.ToString());
                    obj_DAL_Incapacidades.dFecha_Final = Convert.ToDateTime(dataGridView3.SelectedRows[0].Cells[3].Value.ToString());
                    obj_DAL_Incapacidades.iNuemro_Orden = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[4].Value.ToString());
                    obj_DAL_Incapacidades.sDescripcion = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();


                    Pantallas.Mantenimiento.NuevoEditar.frm_Incapacidades_Editar PantIncapacidad = new frm_Incapacidades_Editar();
                    PantIncapacidad.obj_DAL_Modifica_Incapacidad = obj_DAL_Incapacidades;
                    PantIncapacidad.ShowDialog();

                    if (obj_DAL_Vacaciones.sMsjError == "" || obj_DAL_Vacaciones.sMsjError == null)
                    {
                        obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);
                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = obj_DAL_Incapacidades.dtDatos;
                    }

                }
                else
                {
                    MessageBox.Show("No se puede modificar ninguna incapacidad, ya que no tiene una seleccionada.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    obj_DAL_Incapacidades.sEmpleado_ID = "";
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar ninguna incapacidad, ya que no tiene una disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                obj_DAL_Incapacidades.sEmpleado_ID = "";
            }



        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (dgv_Serv_Profesionales.Rows.Count > 0)
            {
                if (dgv_Serv_Profesionales.SelectedRows[0] != null)
                {
                    obj_DAL_Servicios_Profesionales.iServicio_ID = Convert.ToInt32(dgv_Serv_Profesionales.SelectedRows[0].Cells[0].Value.ToString());
                    obj_DAL_Servicios_Profesionales.sNombre = dgv_Serv_Profesionales.SelectedRows[0].Cells[1].Value.ToString();
                    obj_DAL_Servicios_Profesionales.sOferente_ID = dgv_Serv_Profesionales.SelectedRows[0].Cells[2].Value.ToString();
                    obj_DAL_Servicios_Profesionales.iPuesto_ID = Convert.ToInt32(dgv_Serv_Profesionales.SelectedRows[0].Cells[3].Value.ToString());
                    obj_DAL_Servicios_Profesionales.iHoras_Laboradas = Convert.ToInt32(dgv_Serv_Profesionales.SelectedRows[0].Cells[4].Value.ToString());
                    obj_DAL_Servicios_Profesionales.dMonto_Cancelado = Convert.ToDecimal(dgv_Serv_Profesionales.SelectedRows[0].Cells[5].Value.ToString());
                    obj_DAL_Servicios_Profesionales.sServicio_recibido = dgv_Serv_Profesionales.SelectedRows[0].Cells[6].Value.ToString();
                    obj_DAL_Servicios_Profesionales.dFecha_Servicio = Convert.ToDateTime(dgv_Serv_Profesionales.SelectedRows[0].Cells[7].Value.ToString());
                    obj_DAL_Servicios_Profesionales.sEmpleado_ID = dgv_Serv_Profesionales.SelectedRows[0].Cells[8].Value.ToString();



                    Pantallas.Mantenimiento.NuevoEditar.frm_Serv_Profesionales_Editar PantSerPro = new frm_Serv_Profesionales_Editar();
                    PantSerPro.obj_Modifica_Servicios_Profesionales = obj_DAL_Servicios_Profesionales;
                    PantSerPro.ShowDialog();

                    obj_DAL_Servicios_Profesionales.sNombre = textBox13.Text.Trim();
                    obj_BLL_Servicios_Profesionales.Listar_Filtrar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);

                    if ((obj_DAL_Servicios_Profesionales.sMsjError == "") || (obj_DAL_Servicios_Profesionales.sMsjError == null))
                    {
                        dgv_Serv_Profesionales.DataSource = null;
                        dgv_Serv_Profesionales.DataSource = obj_DAL_Servicios_Profesionales.dtDatos;
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error listando los servicios profesionales. " + obj_DAL_Servicios_Profesionales.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar ningún servicio profesional, ya que no tiene uno seleccionado.\nPor favor seleccione un servicio profesionales.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    obj_DAL_Empleado.sEmpleado_ID = "";
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar ningún servicio profesional, ya que no tiene un servicio profesional disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                obj_DAL_Empleado.sEmpleado_ID = "";
            }


        }



        private void button47_Click(object sender, EventArgs e)
        {
            if (dataGridView13.Rows.Count > 0)
            {
                if (dataGridView13.SelectedRows[0] != null)
                {
                    obj_DAL_Puesto.iPuesto_ID = Convert.ToInt32(dataGridView13.SelectedRows[0].Cells[0].Value.ToString());
                    obj_DAL_Puesto.sNombre = dataGridView13.SelectedRows[0].Cells[1].Value.ToString();
                    obj_DAL_Puesto.sFunciones = dataGridView13.SelectedRows[0].Cells[2].Value.ToString();
                    obj_DAL_Puesto.dSalario = Convert.ToDecimal(dataGridView13.SelectedRows[0].Cells[3].Value.ToString());


                    Pantallas.Mantenimiento.NuevoEditar.frm_Puesto_Editar PantSerPro = new frm_Puesto_Editar();
                    PantSerPro.obj_DAL_Modifica_Puesto = obj_DAL_Puesto;
                    PantSerPro.ShowDialog();

                    obj_DAL_Puesto.sNombre = textBox13.Text.Trim();
                    obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);

                    if ((obj_DAL_Puesto.sMsjError == "") || (obj_DAL_Puesto.sMsjError == null))
                    {
                        dataGridView13.DataSource = null;
                        dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error listando los puestos. " + obj_DAL_Puesto.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado seleccionado.\nPor favor seleccione un empleado.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    obj_DAL_Empleado.sEmpleado_ID = "";
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                obj_DAL_Empleado.sEmpleado_ID = "";
            }

        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (dataGridView14.Rows.Count > 0)
            {
                if (dataGridView14.SelectedRows[0] != null)
                {
                    obj_DAL_Vacaciones.iVacaciones_ID = Convert.ToInt32(dataGridView14.SelectedRows[0].Cells[0].Value.ToString());
                    obj_DAL_Vacaciones.sEmpleado_ID = dataGridView14.SelectedRows[0].Cells[1].Value.ToString();
                    obj_DAL_Vacaciones.dDias_Disponibles = Convert.ToDecimal(dataGridView14.SelectedRows[0].Cells[2].Value.ToString());
                    obj_DAL_Vacaciones.iDias_Tomados = Convert.ToInt32(dataGridView14.SelectedRows[0].Cells[3].Value.ToString());
                    obj_DAL_Vacaciones.dFecha_Inicio_Vacaciones = Convert.ToDateTime(dataGridView14.SelectedRows[0].Cells[4].Value.ToString());


                    Pantallas.Mantenimiento.NuevoEditar.frm_Vacaciones_Editar PantSerPro = new frm_Vacaciones_Editar();
                    PantSerPro.obj_Modifica_Vacaciones = obj_DAL_Vacaciones;
                    PantSerPro.ShowDialog();



                    if (obj_DAL_Vacaciones.sMsjError == "" || obj_DAL_Vacaciones.sMsjError == null)
                    {
                        obj_DAL_Vacaciones.sEmpleado_ID = "";
                        obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);
                        dataGridView14.DataSource = null;
                        dataGridView14.DataSource = obj_DAL_Vacaciones.dtDatos;
                    }

                }
                else
                {
                    MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado seleccionado.\nPor favor seleccione un empleado.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    obj_DAL_Empleado.sEmpleado_ID = "";
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                obj_DAL_Empleado.sEmpleado_ID = "";
            }



        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modifica_Empleado_Click(object sender, EventArgs e)
        {
            if (dataGridView12.Rows.Count > 0)
            {
                if (dataGridView12.SelectedRows[0] != null)
                {
                    obj_DAL_Empleado.sEmpleado_ID = dataGridView12.SelectedRows[0].Cells[0].Value.ToString();
                    obj_DAL_Empleado.sNombre = dataGridView12.SelectedRows[0].Cells[1].Value.ToString();
                    obj_DAL_Empleado.sApellidos = dataGridView12.SelectedRows[0].Cells[2].Value.ToString();
                    obj_DAL_Empleado.sDireccion = dataGridView12.SelectedRows[0].Cells[3].Value.ToString();
                    obj_DAL_Empleado.sTelefono_Personal = dataGridView12.SelectedRows[0].Cells[4].Value.ToString();
                    obj_DAL_Empleado.sContacto_Emergencia = dataGridView12.SelectedRows[0].Cells[5].Value.ToString();
                    obj_DAL_Empleado.sCorreo = dataGridView12.SelectedRows[0].Cells[6].Value.ToString();
                    obj_DAL_Empleado.dFecha_Nacimiento = Convert.ToDateTime(dataGridView12.SelectedRows[0].Cells[7].Value.ToString());
                    obj_DAL_Empleado.dFecha_Ingreso = Convert.ToDateTime(dataGridView12.SelectedRows[0].Cells[8].Value.ToString());
                    obj_DAL_Empleado.iPuesto_ID = Convert.ToInt32(dataGridView12.SelectedRows[0].Cells[9].Value.ToString());

                    Pantallas.Mantenimiento.NuevoEditar.frm_Empleado_Editar Edit = new frm_Empleado_Editar();
                    Edit.obj_DAL_Modificar_Empleado = obj_DAL_Empleado;
                    Edit.ShowDialog();

                    if (obj_DAL_Empleado.sMsjError == "" || obj_DAL_Empleado.sMsjError == null)
                    {
                        obj_DAL_Empleado.sEmpleado_ID = "";
                        obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);
                        dataGridView12.DataSource = null;
                        dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;
                    }

                }
                else
                {
                    MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado seleccionado.\nPor favor seleccione un empleado.", "No hay datos seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    obj_DAL_Empleado.sEmpleado_ID = "";
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar ningún empleado, ya que no tiene un empleado disponible para modificar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                obj_DAL_Empleado.sEmpleado_ID = "";
            }




        }

        #region Validaciones

        private void validarPassword(string Contrasenna)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;

            char[] PermitirCaracter = { '"', '[', '$', '&', '+', ',', ':', ';', '=', '?', '@', '#', '|', '<', '>', '.', '-', '^', '*', '(', ')', '%', '!', ']', '/', '_' };
            char[] PermitirMayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] PermitirNumeros = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            foreach (char item in PermitirCaracter)
            {
                if (Contrasenna.Contains(item))
                {
                    flag1 = true;
                    break;
                }

            }

            foreach (char item in PermitirMayusculas)
            {
                if (Contrasenna.Contains(item))
                {
                    flag2 = true;
                    break;
                }
            }

            foreach (char item in PermitirMayusculas)
            {
                if (Contrasenna.Contains(item.ToString().ToLower()))
                {
                    flag3 = true;
                    break;
                }

            }

            foreach (char item in PermitirNumeros)
            {
                if (Contrasenna.Contains(item))
                {
                    flag4 = true;
                    break;
                }
            }

            if (flag1 && flag2 && flag3 && flag4)
            {
                erp_Password_User.SetError(txt_Password, "Debe contener un número.\nDebe contener un caracter especial.");
                btn_CrearUsuario.Enabled = false;
            }
            else
            {
                erp_Password_User.Clear();
                btn_CrearUsuario.Enabled = true;
            }

        }



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
        private void Validaciones_Usuario(TextBox txt, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)) || (char.IsLetter(e.KeyChar)) || (e.KeyChar) == 44)
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

        #region Keypress
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space && textBox2.SelectionStart != 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)))
                {
                    e.Handled = false;
                }
                else
                {
                    if (((e.KeyChar > 32) && (e.KeyChar < 48)) || ((e.KeyChar > 57) && (e.KeyChar < 65)) || ((e.KeyChar > 90) && (e.KeyChar < 97)) || ((e.KeyChar > 122) && (e.KeyChar < 127)))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_Usuario(txt_Usuario, e);
        }

        #endregion

        #region Leave
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            erp_Password_User.Clear();
            if (txt_Password.TextLength < 5)
            {
                erp_Password_User.SetError(txt_Password, "Debe tener al menos 5 caracteres.");
                btn_CrearUsuario.Enabled = false;
            }
            else
            {
                validarPassword(txt_Password.Text);
            }
        }
        #endregion

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView46_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void tabFac_10_Click(object sender, EventArgs e)
        {

        }



        #region Filtrar Nomina

        private void button18_Click(object sender, EventArgs e)
        {

            obj_DAL_Empleado.sEmpleado_ID = textBox12.Text.Trim();
            obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);

            if ((obj_DAL_Empleado.sMsjError == "") || (obj_DAL_Empleado.sMsjError == null))
            {
                dataGridView12.DataSource = null;
                dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los empleados. " + obj_DAL_Empleado.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

            obj_DAL_Empleado.sEmpleado_ID = textBox12.Text.Trim();
            obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);

            if ((obj_DAL_Empleado.sMsjError == "") || (obj_DAL_Empleado.sMsjError == null))
            {
                dataGridView12.DataSource = null;
                dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los empleados. " + obj_DAL_Empleado.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

            obj_DAL_Puesto.sNombre = textBox13.Text.Trim();
            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);

            if ((obj_DAL_Puesto.sMsjError == "") || (obj_DAL_Puesto.sMsjError == null))
            {
                dataGridView13.DataSource = null;
                dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los puestos. " + obj_DAL_Puesto.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            obj_DAL_Puesto.sNombre = textBox13.Text.Trim();
            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);

            if ((obj_DAL_Puesto.sMsjError == "") || (obj_DAL_Puesto.sMsjError == null))
            {
                dataGridView13.DataSource = null;
                dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los puestos. " + obj_DAL_Puesto.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (!textBox14.Text.Equals(""))
            {
                obj_DAL_Vacaciones.sEmpleado_ID = textBox14.Text.Trim();
                obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);

                if ((obj_DAL_Vacaciones.sMsjError == "") || (obj_DAL_Vacaciones.sMsjError == null))
                {
                    dataGridView14.DataSource = null;
                    dataGridView14.DataSource = obj_DAL_Vacaciones.dtDatos;
                }
                else
                {
                    MessageBox.Show("Se presentó un error listando las vacaciones. " + obj_DAL_Vacaciones.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!textBox14.Text.Equals(""))
            {
                obj_DAL_Vacaciones.sEmpleado_ID = textBox14.Text.Trim();
                obj_BLL_Vacaciones.Listar_Filtrar_Vacaciones(ref obj_DAL_Vacaciones);

                if ((obj_DAL_Vacaciones.sMsjError == "") || (obj_DAL_Vacaciones.sMsjError == null))
                {
                    dataGridView14.DataSource = null;
                    dataGridView14.DataSource = obj_DAL_Vacaciones.dtDatos;
                }
                else
                {
                    MessageBox.Show("Se presentó un error listando las vacaciones. " + obj_DAL_Vacaciones.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                obj_DAL_Servicios_Profesionales.sServicio_recibido = textBox2.Text.Trim();
                obj_BLL_Servicios_Profesionales.Listar_Filtrar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);

                if ((obj_DAL_Servicios_Profesionales.sMsjError == "") || (obj_DAL_Servicios_Profesionales.sMsjError == null))
                {
                    dgv_Serv_Profesionales.DataSource = null;
                    dgv_Serv_Profesionales.DataSource = obj_DAL_Servicios_Profesionales.dtDatos;
                }
                else
                {
                    MessageBox.Show("Se presentó un error listando los servicios profesionales. " + obj_DAL_Servicios_Profesionales.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            obj_DAL_Servicios_Profesionales.sServicio_recibido = textBox2.Text.Trim();
            obj_BLL_Servicios_Profesionales.Listar_Filtrar_Servicios_Profesionales(ref obj_DAL_Servicios_Profesionales);

            if ((obj_DAL_Servicios_Profesionales.sMsjError == "") || (obj_DAL_Servicios_Profesionales.sMsjError == null))
            {
                dgv_Serv_Profesionales.DataSource = null;
                dgv_Serv_Profesionales.DataSource = obj_DAL_Servicios_Profesionales.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los servicios profesionales. " + obj_DAL_Servicios_Profesionales.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                obj_DAL_Incapacidades.sEmpleado_ID = textBox1.Text.Trim();
                obj_BLL_Incapacidades.Listar_Filtrar_INCAPACIDADES(ref obj_DAL_Incapacidades);

                if ((obj_DAL_Incapacidades.sMsjError == "") || (obj_DAL_Incapacidades.sMsjError == null))
                {
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = obj_DAL_Incapacidades.dtDatos;
                }
                else
                {
                    MessageBox.Show("Se presentó un error listando los servicios profesionales. " + obj_DAL_Incapacidades.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            obj_DAL_Incapacidades.sEmpleado_ID = textBox1.Text.Trim();
            obj_BLL_Incapacidades.Listar_Filtrar_INCAPACIDADES(ref obj_DAL_Incapacidades);

            if ((obj_DAL_Incapacidades.sMsjError == "") || (obj_DAL_Incapacidades.sMsjError == null))
            {
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = obj_DAL_Incapacidades.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error listando los servicios profesionales. " + obj_DAL_Incapacidades.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }





        #endregion

        #region Eliminar-Nomina
        private void button50_Click(object sender, EventArgs e)
        {
            if (dataGridView12.Rows.Count > 0)
            {
                if (dataGridView12.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Desea eliminar el Empleado [" + dataGridView12.SelectedRows[0].Cells[0].Value.ToString()
                        + ", " + dataGridView12.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + dataGridView12.SelectedRows[0].Cells[2].Value.ToString().Trim() + "]...???",
                        "¿Seguro que quiere eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj_DAL_Empleado.sEmpleado_ID = dataGridView12.SelectedRows[0].Cells[0].Value.ToString();
                        obj_DAL_Empleado.sNombre = dataGridView12.SelectedRows[0].Cells[1].Value.ToString();
                        obj_DAL_Empleado.sApellidos = dataGridView12.SelectedRows[0].Cells[2].Value.ToString();
                        obj_DAL_Empleado.sDireccion = dataGridView12.SelectedRows[0].Cells[3].Value.ToString();
                        obj_DAL_Empleado.sTelefono_Personal = dataGridView12.SelectedRows[0].Cells[4].Value.ToString();
                        obj_DAL_Empleado.sContacto_Emergencia = dataGridView12.SelectedRows[0].Cells[5].Value.ToString();
                        obj_DAL_Empleado.sCorreo = dataGridView12.SelectedRows[0].Cells[6].Value.ToString();
                        obj_DAL_Empleado.dFecha_Nacimiento = Convert.ToDateTime(dataGridView12.SelectedRows[0].Cells[7].Value.ToString());
                        obj_DAL_Empleado.dFecha_Ingreso = Convert.ToDateTime(dataGridView12.SelectedRows[0].Cells[8].Value.ToString());
                        obj_DAL_Empleado.iPuesto_ID = Convert.ToInt32(dataGridView12.SelectedRows[0].Cells[9].Value.ToString());
                        obj_DAL_Empleado.iVacaciones = Convert.ToInt32(dataGridView12.SelectedRows[0].Cells[10].Value.ToString());

                        obj_BLL_Empleado.Eliminar_EMPLEADOS(ref obj_DAL_Empleado);

                        if ((obj_DAL_Empleado.sMsjError == string.Empty) || (obj_DAL_Empleado.sMsjError == null))
                        {
                            MessageBox.Show("Empleado [" + dataGridView12.SelectedRows[0].Cells[0].Value.ToString()
                        + ", " + dataGridView12.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + dataGridView12.SelectedRows[0].Cells[2].Value.ToString().Trim() + "] fue eliminada exitosamente.",
                        "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBox12.Clear();

                            obj_DAL_Empleado.sEmpleado_ID = textBox12.Text.Trim();
                            obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);

                            if ((obj_DAL_Empleado.sMsjError == "") || (obj_DAL_Empleado.sMsjError == null))
                            {
                                dataGridView12.DataSource = null;
                                dataGridView12.DataSource = obj_DAL_Empleado.dtDatos;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en el borrado del cliente seleccionado. " + obj_DAL_Empleado.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se puede eliminar ningún empleado, ya que no tiene ninguno seleccionado.\nPor favor seleccione un empleado.", "No hay empleados seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar ningún empleado, ya que no hay empleados disponibles para eliminar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void button51_Click_1(object sender, EventArgs e)
        {
            if (dataGridView13.Rows.Count > 0)
            {
                if (dataGridView13.SelectedRows[0] != null)
                {
                    if (MessageBox.Show("Desea eliminar el Puesto [" + dataGridView13.SelectedRows[0].Cells[0].Value.ToString()
                        + ", " + dataGridView13.SelectedRows[0].Cells[1].Value.ToString().Trim() + "]...???",
                        "¿Seguro que quiere eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj_DAL_Puesto.iPuesto_ID = Convert.ToInt32(dataGridView13.SelectedRows[0].Cells[0].Value.ToString());
                        obj_DAL_Puesto.sNombre = dataGridView13.SelectedRows[0].Cells[1].Value.ToString();
                        obj_DAL_Puesto.sFunciones = dataGridView13.SelectedRows[0].Cells[2].Value.ToString();
                        obj_DAL_Puesto.dSalario = Convert.ToDecimal(dataGridView13.SelectedRows[0].Cells[3].Value.ToString());


                        obj_BLL_Puesto.Eliminar_Puesto(ref obj_DAL_Puesto);

                        if ((obj_DAL_Puesto.sMsjError == string.Empty) || (obj_DAL_Puesto.sMsjError == null))
                        {
                            MessageBox.Show("Puesto [" + dataGridView13.SelectedRows[0].Cells[0].Value.ToString()
                        + ", " + dataGridView13.SelectedRows[0].Cells[1].Value.ToString().Trim() + "] fue eliminado exitosamente.",
                        "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBox13.Clear();
                            obj_DAL_Puesto.sNombre = textBox13.Text.Trim();

                            obj_BLL_Puesto.Listar_Filtrar_Puesto(ref obj_DAL_Puesto);

                            if ((obj_DAL_Puesto.sMsjError == "") || (obj_DAL_Puesto.sMsjError == null))
                            {
                                dataGridView13.DataSource = null;
                                dataGridView13.DataSource = obj_DAL_Puesto.dtDatos;
                            }
                            else
                            {
                                MessageBox.Show("Se presentó un error listando los puestos. " + obj_DAL_Puesto.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en el borrado del puesto seleccionado. " + obj_DAL_Puesto.sMsjError, "Error presentado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se puede eliminar ningún puesto, ya que no tiene ninguno seleccionado.\nPor favor seleccione un puesto.", "No hay empleados seleccionados",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar ningún puesto, ya que no hay puestos disponibles para eliminar.", "No hay datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tb_Empleados_Click(object sender, EventArgs e)
        {
            obj_BLL_Empleado.Listar_Filtrar_EMPLEADOS(ref obj_DAL_Empleado);
        }

        private void frm_administracion_Load(object sender, EventArgs e)
        {
            cargarDatosPlatillos();
            cargarDataGridFact();//Temporal
            cargarDatosFactura();
            cargarDatosFactura2();
            cargarDatosFactura3();
            cargarDatosFactura4();
            cargarDatosFactura10();
            //calc_Facturar();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)//textbox filtrar
        {
            cargarDatosPlatillos();
        }

        private void button13_Click(object sender, EventArgs e)//Eliminar Platillo
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("No puede, debe de seleccionar un registro de la tabla para poder ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (MessageBox.Show("Desea realmente eliminar el platillo " + dataGridView5.SelectedRows[0].Cells[1].Value.ToString().Trim().ToUpper() + "??", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj_platillo_DAL.iPlatillo_ID = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    obj_platillo_BLL.Eliminar_Platillo(ref obj_platillo_DAL);

                    if (obj_platillo_DAL.sMsjError != string.Empty)
                    {
                        MessageBox.Show("Se presentó un error al tratar de eliminar el Platillo seleccionado [ " + obj_platillo_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Platillo eliminado exitosamente!", "Ejecucion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cargarDatosPlatillos();
                }

            }
        }


        #region EVENTOS FACTURACION

        private void btn_cobrar_mesa1_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 1;
        }

        private void btn_cobrar_mesa2_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 2;
        }

        private void btn_cobrar_mesa3_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 3;
        }

        private void btn_cobrar_mesa4_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 4;
        }

        private void btn_cobrar_mesa5_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 5;
        }

        private void btn_cobrar_mesa6_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 6;
        }

        private void btn_cobrar_mesa7_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 7;
        }

        private void btn_cobrar_mesa8_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 8;
        }

        private void btn_cobrar_mesa9_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 9;
        }

        private void btn_cobrar_mesa10_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 10;
        }

        private void btn_cobrar_mesa1_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 1;
        }

        private void btn_cobrar_mesa2_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 2;
        }

        private void btn_cobrar_mesa3_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 3;
        }

        private void btn_cobrar_mesa4_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 4;
        }

        private void btn_cobrar_mesa5_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 5;
        }

        private void btn_cobrar_mesa6_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 6;
        }

        private void btn_cobrar_mesa7_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 7;
        }

        private void btn_cobrar_mesa8_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 8;
        }

        private void btn_cobrar_mesa9_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 9;
        }

        private void btn_cobrar_mesa10_No_Disp_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 10;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button98_Click_1(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_pasar_der_Click(object sender, EventArgs e)
        {

            if (dgv_Mesa_1_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btn_pasar_iz_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_1_PagarSeparado.SelectedRows.Count == 1)
            {
                pasar_a_pagar_total();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void btn_Pagar_mesa1_Click(object sender, EventArgs e)
        {
            calc_Facturar();

            if (cbx_metPago_Fact_M1.SelectedIndex == 4)
            {
                MessageBox.Show("Debe seleccionar un metodo de pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                Pantallas.Facturacion.Factura Pant_Edit_Fact = new Facturacion.Factura();
                Pant_Edit_Fact.Obj_Edit_DAL = obj_factura_DAL;
                Pant_Edit_Fact.ShowDialog();

                if (dgv_Mesa_1_PagarSeparado.Rows.Count == 0)
                {

                    btn_v_mesa_I.Visible = true;
                    btn_r_mesa_I.Visible = false;
                    btn_cobrar_mesa1_No_Disp.Visible = false;

                    txt_Prop_Fact_M1.Text = "0";
                    txt_Desc_Fact_M1.Text = "0";

                    //insertarDatosFactura();

                    dgv_Mesa_1_TotalCuenta.Columns.Clear();
                }
                else
                {

                    btn_v_mesa_I.Visible = true;
                    btn_r_mesa_I.Visible = false;
                    btn_cobrar_mesa1_No_Disp.Visible = false;

                    txt_Prop_Fact_M1.Text = "0";
                    txt_Desc_Fact_M1.Text = "0";

                    //insertarDatosFactura();

                    dgv_Mesa_1_PagarSeparado.Rows.Clear();

                }

                

                cbx_metPago_Fact_M1.SelectedValue = "0";
            }


        }

        private void btn_Pagar_mesa2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_II.Visible = true;
            btn_r_mesa_II.Visible = false;
            btn_cobrar_mesa2_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_III.Visible = true;
            btn_r_mesa_III.Visible = false;
            btn_cobrar_mesa3_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_IV.Visible = true;
            btn_r_mesa_IV.Visible = false;
            btn_cobrar_mesa4_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_V.Visible = true;
            btn_r_mesa_V.Visible = false;
            btn_cobrar_mesa5_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_VI.Visible = true;
            btn_r_mesa_VI.Visible = false;
            btn_cobrar_mesa6_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_VII.Visible = true;
            btn_r_mesa_VII.Visible = false;
            btn_cobrar_mesa7_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_VIII.Visible = true;
            btn_r_mesa_VIII.Visible = false;
            btn_cobrar_mesa8_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_Pagar_mesa9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_IX.Visible = true;
            btn_r_mesa_IX.Visible = false;
            btn_cobrar_mesa9_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btn_v_mesa_X.Visible = true;
            btn_r_mesa_X.Visible = false;
            btn_cobrar_mesa10_No_Disp.Visible = false;

            btn_pasar_der_M10.SelectedIndex = 0;
        }

        private void btn_verTotal_M1_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void btn_limp_M1_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M1.Text = "0";
            txt_Desc_Fact_M1.Text = "0";
            cbx_metPago_Fact_M1.SelectedValue = "0";

            dgv_Mesa_1_PagarSeparado.Rows.Clear();
            dgv_Mesa_1_TotalCuenta.DataSource = null;

            cargarDatosFactura();
        }

        private void btn_actualizar_RepVentasDiarias_Click(object sender, EventArgs e)
        {
            cargarDatosFactura();
        }

        private void cbx_metPago_Fact_M1_SelectedIndexChanged(object sender, EventArgs e)//Valida que un valor del Combobox sea seleccionado y sea diferente del index 5 que es el default
        {
            if (!cbx_metPago_Fact_M1.SelectedIndex.Equals(5))
            {
                btn_Pagar_mesa1.Enabled = true;
            }
            else
            {
                btn_Pagar_mesa1.Enabled = false;
            }
        }

        private void button37_Click_1(object sender, EventArgs e)//Pagar Mesa 2
        {
            if (dgv_Mesa_2_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_II.Visible = true;
                btn_r_mesa_II.Visible = false;
                btn_cobrar_mesa2_No_Disp.Visible = false;

                txt_Prop_Fact_M2.Text = "0";
                txt_Desc_Fact_M2.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_2_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_II.Visible = true;
                btn_r_mesa_II.Visible = false;
                btn_cobrar_mesa2_No_Disp.Visible = false;

                txt_Prop_Fact_M2.Text = "0";
                txt_Desc_Fact_M2.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_2_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M2.SelectedValue = "0";
        }

        private void button34_Click(object sender, EventArgs e)//Limpiar M2
        {
            txt_Prop_Fact_M2.Text = "0";
            txt_Desc_Fact_M2.Text = "0";
            cbx_metPago_Fact_M2.SelectedValue = "0";

            dgv_Mesa_2_PagarSeparado.Rows.Clear();
            dgv_Mesa_2_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            
        }

        private void button35_Click_1(object sender, EventArgs e)//Ver total M2
        {
            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_3_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_III.Visible = true;
                btn_r_mesa_III.Visible = false;
                btn_cobrar_mesa3_No_Disp.Visible = false;

                txt_Prop_Fact_M3.Text = "0";
                txt_Desc_Fact_M3.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_3_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_III.Visible = true;
                btn_r_mesa_III.Visible = false;
                btn_cobrar_mesa3_No_Disp.Visible = false;

                txt_Prop_Fact_M3.Text = "0";
                txt_Desc_Fact_M3.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_2_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M3.SelectedValue = "0";
        }

        private void button53_Click_1(object sender, EventArgs e)
        {
            txt_Prop_Fact_M3.Text = "0";
            txt_Desc_Fact_M3.Text = "0";
            cbx_metPago_Fact_M3.SelectedValue = "0";

            dgv_Mesa_3_PagarSeparado.Rows.Clear();
            dgv_Mesa_3_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            
        }

        private void button54_Click(object sender, EventArgs e)
        {
            
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_4_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_IV.Visible = true;
                btn_r_mesa_IV.Visible = false;
                btn_cobrar_mesa4_No_Disp.Visible = false;

                txt_Prop_Fact_M4.Text = "0";
                txt_Desc_Fact_M4.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_4_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_IV.Visible = true;
                btn_r_mesa_IV.Visible = false;
                btn_cobrar_mesa4_No_Disp.Visible = false;

                txt_Prop_Fact_M4.Text = "0";
                txt_Desc_Fact_M4.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_4_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M4.SelectedValue = "0";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M4.Text = "0";
            txt_Desc_Fact_M4.Text = "0";
            cbx_metPago_Fact_M4.SelectedValue = "0";

            dgv_Mesa_4_PagarSeparado.Rows.Clear();
            dgv_Mesa_4_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            
        }

        private void button61_Click(object sender, EventArgs e)
        {
            
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_5_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_V.Visible = true;
                btn_r_mesa_V.Visible = false;
                btn_cobrar_mesa5_No_Disp.Visible = false;

                txt_Prop_Fact_M5.Text = "0";
                txt_Desc_Fact_M5.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_5_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_V.Visible = true;
                btn_r_mesa_V.Visible = false;
                btn_cobrar_mesa5_No_Disp.Visible = false;

                txt_Prop_Fact_M5.Text = "0";
                txt_Desc_Fact_M5.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_5_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M5.SelectedValue = "0";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M5.Text = "0";
            txt_Desc_Fact_M5.Text = "0";
            cbx_metPago_Fact_M5.SelectedValue = "0";

            dgv_Mesa_5_PagarSeparado.Rows.Clear();
            dgv_Mesa_5_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_6_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VI.Visible = true;
                btn_r_mesa_VI.Visible = false;
                btn_cobrar_mesa6_No_Disp.Visible = false;

                txt_Prop_Fact_M6.Text = "0";
                txt_Desc_Fact_M6.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_6_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VI.Visible = true;
                btn_r_mesa_VI.Visible = false;
                btn_cobrar_mesa6_No_Disp.Visible = false;

                txt_Prop_Fact_M6.Text = "0";
                txt_Desc_Fact_M6.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_6_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M6.SelectedValue = "0";
        }

        private void button86_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M6.Text = "0";
            txt_Desc_Fact_M6.Text = "0";
            cbx_metPago_Fact_M6.SelectedValue = "0";

            dgv_Mesa_6_PagarSeparado.Rows.Clear();
            dgv_Mesa_6_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_7_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VII.Visible = true;
                btn_r_mesa_VII.Visible = false;
                btn_cobrar_mesa7_No_Disp.Visible = false;

                txt_Prop_Fact_M7.Text = "0";
                txt_Desc_Fact_M7.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_7_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VII.Visible = true;
                btn_r_mesa_VII.Visible = false;
                btn_cobrar_mesa7_No_Disp.Visible = false;

                txt_Prop_Fact_M7.Text = "0";
                txt_Desc_Fact_M7.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_7_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M7.SelectedValue = "0";
        }

        private void button93_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M7.Text = "0";
            txt_Desc_Fact_M7.Text = "0";
            cbx_metPago_Fact_M7.SelectedValue = "0";

            dgv_Mesa_7_PagarSeparado.Rows.Clear();
            dgv_Mesa_7_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_8_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VIII.Visible = true;
                btn_r_mesa_VIII.Visible = false;
                btn_cobrar_mesa8_No_Disp.Visible = false;

                txt_Prop_Fact_M8.Text = "0";
                txt_Desc_Fact_M8.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_8_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_VIII.Visible = true;
                btn_r_mesa_VIII.Visible = false;
                btn_cobrar_mesa8_No_Disp.Visible = false;

                txt_Prop_Fact_M8.Text = "0";
                txt_Desc_Fact_M8.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_8_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M8.SelectedValue = "0";
        }

        private void button99_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M8.Text = "0";
            txt_Desc_Fact_M8.Text = "0";
            cbx_metPago_Fact_M8.SelectedValue = "0";

            dgv_Mesa_8_PagarSeparado.Rows.Clear();
            dgv_Mesa_8_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_9_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_IX.Visible = true;
                btn_r_mesa_IX.Visible = false;
                btn_cobrar_mesa9_No_Disp.Visible = false;

                txt_Prop_Fact_M9.Text = "0";
                txt_Desc_Fact_M9.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_9_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_IX.Visible = true;
                btn_r_mesa_IX.Visible = false;
                btn_cobrar_mesa9_No_Disp.Visible = false;

                txt_Prop_Fact_M9.Text = "0";
                txt_Desc_Fact_M9.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_9_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M9.SelectedValue = "0";
        }

        private void button107_Click(object sender, EventArgs e)
        {
            txt_Prop_Fact_M9.Text = "0";
            txt_Desc_Fact_M9.Text = "0";
            cbx_metPago_Fact_M9.SelectedValue = "0";

            dgv_Mesa_9_PagarSeparado.Rows.Clear();
            dgv_Mesa_9_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            calc_Facturar();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            calc_Facturar();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_10_PagarSeparado.Rows.Count == 0)
            {

                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_X.Visible = true;
                btn_r_mesa_X.Visible = false;
                btn_cobrar_mesa10_No_Disp.Visible = false;

                txt_Prop_Fact_M10.Text = "0";
                txt_Desc_Fact_M10.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_10_TotalCuenta.Columns.Clear();
            }
            else
            {
                MessageBox.Show("Pago realizado exitosamente", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_v_mesa_X.Visible = true;
                btn_r_mesa_X.Visible = false;
                btn_cobrar_mesa10_No_Disp.Visible = false;

                txt_Prop_Fact_M10.Text = "0";
                txt_Desc_Fact_M10.Text = "0";

                insertarDatosFactura();

                dgv_Mesa_10_PagarSeparado.Rows.Clear();

            }
            cbx_metPago_Fact_M10.SelectedValue = "0";
        }

        private void button103_Click_1(object sender, EventArgs e)
        {
            txt_Prop_Fact_M10.Text = "0";
            txt_Desc_Fact_M10.Text = "0";
            cbx_metPago_Fact_M10.SelectedValue = "0";

            dgv_Mesa_10_PagarSeparado.Rows.Clear();
            dgv_Mesa_10_TotalCuenta.DataSource = null;

            cargarDatosFactura();

            
        }

        private void button110_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pasar_der_M2_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_2_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado2();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pasar_der_M3_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_3_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado3();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pasar_der_M4_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_4_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado4();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (dgv_Mesa_10_TotalCuenta.SelectedRows.Count == 1)
            {
                pasar_a_pagar_x_separado10();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



        #region METODOS

        private void calc_Facturar()
        {
            subtotal = 0;
            impuesto = 0;
            propina = 0;
            descuento = 0;
            cargoXservicio = 0;
            total = 0;

            if (dgv_Mesa_1_PagarSeparado.Rows.Count == 0)
            {
                foreach (DataGridViewRow row in dgv_Mesa_1_TotalCuenta.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
                }
                txt_subTotal_Fact_M1.Text = subtotal.ToString();
                obj_factura_DAL.dSubtotal = subtotal;

                impuesto = subtotal * 0.13;
                txt_Impuesto_Fact_M1.Text = impuesto.ToString();
                obj_factura_DAL.dIva = impuesto;

                propina = Convert.ToDouble(txt_Prop_Fact_M1.Text);
                obj_factura_DAL.dTIPS_Propina = propina;

                descuento = Convert.ToDouble(txt_Desc_Fact_M1.Text);
                descuento = descuento / 100;

                cargoXservicio = subtotal * 0.10;
                txt_CargoxServicio_Fact_M1.Text = cargoXservicio.ToString();
                obj_factura_DAL.dImpuesto_Servicio = cargoXservicio;

                descuento = descuento * (subtotal + impuesto + cargoXservicio);
                txt_monto_desc_M1.Text = descuento.ToString();
                obj_factura_DAL.dDescuento = descuento;

                total = subtotal + impuesto + propina - descuento + cargoXservicio;
                txt_Total_Fact_M1.Text = total.ToString();
                obj_factura_DAL.dTotal_Pago = total;

                if (cbx_metPago_Fact_M1.SelectedIndex == 0)
                {
                    obj_factura_DAL.sMetodoPago = "Efectivo";
                }
                else if(cbx_metPago_Fact_M1.SelectedIndex == 1)
                {
                    obj_factura_DAL.sMetodoPago = "SINPE Movil";
                }
                else if (cbx_metPago_Fact_M1.SelectedIndex == 2)
                {
                    obj_factura_DAL.sMetodoPago = "Tarjeta Debito";
                }
                else if (cbx_metPago_Fact_M1.SelectedIndex == 3)
                {
                    obj_factura_DAL.sMetodoPago = "Tarjeta Credito";
                }

            }
            else
            {
                foreach (DataGridViewRow row in dgv_Mesa_1_PagarSeparado.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
                }
                txt_subTotal_Fact_M1.Text = subtotal.ToString();
                obj_factura_DAL.dSubtotal = subtotal;

                impuesto = subtotal * 0.13;
                txt_Impuesto_Fact_M1.Text = impuesto.ToString();
                obj_factura_DAL.dIva = impuesto;

                propina = Convert.ToDouble(txt_Prop_Fact_M1.Text);
                obj_factura_DAL.dTIPS_Propina = propina;

                descuento = Convert.ToDouble(txt_Desc_Fact_M1.Text);
                descuento = descuento / 100;

                cargoXservicio = subtotal * 0.10;
                txt_CargoxServicio_Fact_M1.Text = cargoXservicio.ToString();
                obj_factura_DAL.dImpuesto_Servicio = cargoXservicio;

                descuento = descuento * (subtotal + impuesto + cargoXservicio);
                txt_monto_desc_M1.Text = descuento.ToString();
                obj_factura_DAL.dDescuento = descuento;

                total = subtotal + impuesto + propina - descuento + cargoXservicio;
                txt_Total_Fact_M1.Text = total.ToString();
                obj_factura_DAL.dTotal_Pago = total;
            }



        }

        private void cargarDatosPlatillos()
        {
            obj_platillo_DAL.sNombre = textBox6.Text;//textbox para filtrar
            obj_platillo_BLL.Listar_Filtrar_Platillo(ref obj_platillo_DAL);

            dataGridView5.DataSource = null;//datagrid de platillos

            if (obj_platillo_DAL.sMsjError == string.Empty)
            {
                dataGridView5.DataSource = obj_platillo_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_platillo_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDatosFactura()
        {
            cargarComboBoxFact();//Carga el combobox de la pantalla Mesa 1 de Facturacion
            cbx_metPago_Fact_M1.SelectedValue = "0";

            dgv_Mesa_1_TotalCuenta.DataSource = null;

            obj_factura_DAL.cMesa = '1';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_1_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDatosFactura2()
        {
            cargarComboBoxFact();
            cbx_metPago_Fact_M2.SelectedValue = "0";

            dgv_Mesa_2_TotalCuenta.DataSource = null;

            obj_factura_DAL.cMesa = '2';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_2_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDatosFactura3()
        {
            cargarComboBoxFact();
            cbx_metPago_Fact_M3.SelectedValue = "0";

            dgv_Mesa_3_TotalCuenta.DataSource = null;

            obj_factura_DAL.cMesa = '3';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_3_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDatosFactura4()
        {
            cargarComboBoxFact();
            cbx_metPago_Fact_M4.SelectedValue = "0";

            dgv_Mesa_4_TotalCuenta.DataSource = null;

            obj_factura_DAL.cMesa = '4';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_4_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDatosFactura10()
        {
            cargarComboBoxFact();
            cbx_metPago_Fact_M10.SelectedValue = "0";

            dgv_Mesa_10_TotalCuenta.DataSource = null;

            //obj_factura_DAL.cMesa = '10';
            obj_factura_BLL.Listar_Filtrar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError == string.Empty)
            {
                dgv_Mesa_10_TotalCuenta.DataSource = obj_factura_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void insertarDatosFactura()
        {
            DateTime fecha = DateTime.Today;

            obj_factura_DAL.iOrden_Detalle_ID = 2;//Falta informacion de Salon
            obj_factura_DAL.dtFecha = fecha;
            obj_factura_DAL.iMetodo_Pago_ID = Convert.ToInt32(cbx_metPago_Fact_M1.SelectedValue.ToString().Trim());
            //obj_factura_DAL.dSubtotal = Convert.ToDecimal(subtotal);
            //obj_factura_DAL.dIva = Convert.ToDecimal(impuesto);
            //obj_factura_DAL.dDescuento = Convert.ToDecimal(descuento);
            //obj_factura_DAL.dImpuesto_Servicio = Convert.ToDecimal(cargoXservicio);
            //obj_factura_DAL.dTIPS_Propina = Convert.ToDecimal(propina);
            //obj_factura_DAL.dTotal_Pago = Convert.ToDecimal(total);

            obj_factura_BLL.Insertar_Factura(ref obj_factura_DAL);

            if (obj_factura_DAL.sMsjError != string.Empty)
            {
                MessageBox.Show("Se presentó un error al tratar de agregar el Platillo seleccionado [ " + obj_factura_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Factura generada exitosamente exitosamente!", "Ejecucion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void editarPlatilloSeleccionado()
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("No puede, debe de seleccionar un registro de la tabla para poder ser modificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                obj_platillo_DAL.iPlatillo_ID = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value.ToString());
                obj_platillo_DAL.sNombre = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
                obj_platillo_DAL.dPrecio_Con_IVA = Convert.ToDecimal(dataGridView5.SelectedRows[0].Cells[2].Value.ToString());
                obj_platillo_DAL.cOperacion = 'U';

                Pantallas.Mantenimiento.NuevoEditar.frm_Platillo_Nuevo Pant_Edit_Platillo = new frm_Platillo_Nuevo();
                Pant_Edit_Platillo.Obj_Edit_DAL = obj_platillo_DAL;
                Pant_Edit_Platillo.ShowDialog();
            }
        }

        private void cargarDataGridFact() {//Metodo para insertar valores quemados en Facturacion

            /*dgv_Mesa_1_TotalCuenta.Rows.Add("Casado de Cerdo","3500");
            dgv_Mesa_1_TotalCuenta.Rows.Add("Refresco Natural", "1200");
            dgv_Mesa_1_TotalCuenta.Rows.Add("Postre Fresa", "2000");
            dgv_Mesa_1_TotalCuenta.Rows.Add("Casado de Res", "3500");*/

        }//Temporal

        private void pasar_a_pagar_x_separado()
        {
            dgv_Mesa_1_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_1_TotalCuenta[0, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_1_TotalCuenta[1, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_1_TotalCuenta.Rows.RemoveAt(dgv_Mesa_1_TotalCuenta.CurrentRow.Index);
        }

        private void pasar_a_pagar_x_separado2()
        {
            dgv_Mesa_2_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_2_TotalCuenta[0, dgv_Mesa_2_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_2_TotalCuenta[1, dgv_Mesa_2_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_2_TotalCuenta.Rows.RemoveAt(dgv_Mesa_2_TotalCuenta.CurrentRow.Index);
        }

        private void pasar_a_pagar_x_separado3()
        {
            dgv_Mesa_3_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_3_TotalCuenta[0, dgv_Mesa_3_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_3_TotalCuenta[1, dgv_Mesa_3_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_3_TotalCuenta.Rows.RemoveAt(dgv_Mesa_3_TotalCuenta.CurrentRow.Index);
        }

        private void pasar_a_pagar_x_separado4()
        {
            dgv_Mesa_4_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_4_TotalCuenta[0, dgv_Mesa_4_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_4_TotalCuenta[1, dgv_Mesa_4_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_4_TotalCuenta.Rows.RemoveAt(dgv_Mesa_4_TotalCuenta.CurrentRow.Index);
        }

        private void pasar_a_pagar_x_separado10()
        {
            dgv_Mesa_10_PagarSeparado.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_10_TotalCuenta[0, dgv_Mesa_10_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_10_TotalCuenta[1, dgv_Mesa_10_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_10_TotalCuenta.Rows.RemoveAt(dgv_Mesa_10_TotalCuenta.CurrentRow.Index);
        }

        private void pasar_a_pagar_total()
        {

            dgv_Mesa_1_TotalCuenta.Rows.Add(new string[] {
            Convert.ToString(dgv_Mesa_1_PagarSeparado[0, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value),
            Convert.ToString(dgv_Mesa_1_PagarSeparado[1, dgv_Mesa_1_TotalCuenta.CurrentRow.Index].Value)
            });

            dgv_Mesa_1_PagarSeparado.Rows.RemoveAt(dgv_Mesa_1_TotalCuenta.CurrentRow.Index);
        }

        private void cargarComboBoxFact()
        {

            obj_metPago_BLL.Listar_Filtrar_METODODEPAGO(ref obj_metPago_DAL);

            cbx_metPago_Fact_M1.DataSource = null;
            cbx_metPago_Fact_M2.DataSource = null;
            cbx_metPago_Fact_M3.DataSource = null;
            cbx_metPago_Fact_M4.DataSource = null;
            cbx_metPago_Fact_M5.DataSource = null;
            cbx_metPago_Fact_M6.DataSource = null;
            cbx_metPago_Fact_M7.DataSource = null;
            cbx_metPago_Fact_M8.DataSource = null;
            cbx_metPago_Fact_M9.DataSource = null;
            cbx_metPago_Fact_M10.DataSource = null;

            if (obj_metPago_DAL.sMsjError == string.Empty)
            {
                obj_metPago_DAL.dtDatos.Rows.Add("0", "--- Seleccione ---");
                cbx_metPago_Fact_M1.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M2.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M3.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M4.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M5.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M6.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M7.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M8.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M9.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M10.DataSource = obj_metPago_DAL.dtDatos;
                cbx_metPago_Fact_M1.DisplayMember = "Nombre";
                cbx_metPago_Fact_M2.DisplayMember = "Nombre";
                cbx_metPago_Fact_M3.DisplayMember = "Nombre";
                cbx_metPago_Fact_M4.DisplayMember = "Nombre";
                cbx_metPago_Fact_M5.DisplayMember = "Nombre";
                cbx_metPago_Fact_M6.DisplayMember = "Nombre";
                cbx_metPago_Fact_M7.DisplayMember = "Nombre";
                cbx_metPago_Fact_M8.DisplayMember = "Nombre";
                cbx_metPago_Fact_M9.DisplayMember = "Nombre";
                cbx_metPago_Fact_M10.DisplayMember = "Nombre";
                cbx_metPago_Fact_M1.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M2.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M3.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M4.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M5.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M6.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M7.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M8.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M9.ValueMember = "Metodo_Pago_ID";
                cbx_metPago_Fact_M10.ValueMember = "Metodo_Pago_ID";
            }
            else
            {
                MessageBox.Show("Se presentó un error al ejecutar el metodo Listar_Filtrar [ " + obj_metPago_DAL.sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        #endregion

    }
}




