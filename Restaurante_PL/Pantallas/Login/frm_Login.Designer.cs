
namespace Plantilla_Diseño_2.Pantallas.Login
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pn_cerrar = new System.Windows.Forms.Panel();
            this.tb_Login_Main = new System.Windows.Forms.TabControl();
            this.tb_InicioSesion = new System.Windows.Forms.TabPage();
            this.btn_Login_recConstrasena = new System.Windows.Forms.Button();
            this.btn_login_clear = new System.Windows.Forms.Button();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.txt_login_Nombre = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_RecContra = new System.Windows.Forms.TabPage();
            this.btn_RecConAceptar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_IngresoCont = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contraseña2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_agregarContraseña = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Login_close = new System.Windows.Forms.Button();
            this.pb_Login_LogoRes = new System.Windows.Forms.PictureBox();
            this.pb_Login_Password = new System.Windows.Forms.PictureBox();
            this.pb_Login_User = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volverAgregarContraseña = new System.Windows.Forms.Button();
            this.pn_cerrar.SuspendLayout();
            this.tb_Login_Main.SuspendLayout();
            this.tb_InicioSesion.SuspendLayout();
            this.tb_RecContra.SuspendLayout();
            this.tb_IngresoCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_LogoRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cerrar
            // 
            this.pn_cerrar.BackColor = System.Drawing.Color.Goldenrod;
            this.pn_cerrar.Controls.Add(this.btn_Login_close);
            this.pn_cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_cerrar.Location = new System.Drawing.Point(0, 0);
            this.pn_cerrar.Name = "pn_cerrar";
            this.pn_cerrar.Size = new System.Drawing.Size(492, 31);
            this.pn_cerrar.TabIndex = 4;
            this.pn_cerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_cerrar_MouseDown);
            // 
            // tb_Login_Main
            // 
            this.tb_Login_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tb_Login_Main.Controls.Add(this.tb_InicioSesion);
            this.tb_Login_Main.Controls.Add(this.tb_RecContra);
            this.tb_Login_Main.Controls.Add(this.tb_IngresoCont);
            this.tb_Login_Main.ItemSize = new System.Drawing.Size(10, 10);
            this.tb_Login_Main.Location = new System.Drawing.Point(-5, 12);
            this.tb_Login_Main.Name = "tb_Login_Main";
            this.tb_Login_Main.SelectedIndex = 0;
            this.tb_Login_Main.Size = new System.Drawing.Size(506, 580);
            this.tb_Login_Main.TabIndex = 7;
            // 
            // tb_InicioSesion
            // 
            this.tb_InicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.tb_InicioSesion.Controls.Add(this.btn_Login_recConstrasena);
            this.tb_InicioSesion.Controls.Add(this.pb_Login_LogoRes);
            this.tb_InicioSesion.Controls.Add(this.btn_login_clear);
            this.tb_InicioSesion.Controls.Add(this.txt_login_password);
            this.tb_InicioSesion.Controls.Add(this.txt_login_Nombre);
            this.tb_InicioSesion.Controls.Add(this.btn_login);
            this.tb_InicioSesion.Controls.Add(this.panel2);
            this.tb_InicioSesion.Controls.Add(this.panel1);
            this.tb_InicioSesion.Controls.Add(this.pb_Login_Password);
            this.tb_InicioSesion.Controls.Add(this.pb_Login_User);
            this.tb_InicioSesion.Location = new System.Drawing.Point(4, 14);
            this.tb_InicioSesion.Name = "tb_InicioSesion";
            this.tb_InicioSesion.Padding = new System.Windows.Forms.Padding(3);
            this.tb_InicioSesion.Size = new System.Drawing.Size(498, 533);
            this.tb_InicioSesion.TabIndex = 0;
            // 
            // btn_Login_recConstrasena
            // 
            this.btn_Login_recConstrasena.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login_recConstrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Login_recConstrasena.FlatAppearance.BorderSize = 0;
            this.btn_Login_recConstrasena.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Login_recConstrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_recConstrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_recConstrasena.ForeColor = System.Drawing.Color.White;
            this.btn_Login_recConstrasena.Location = new System.Drawing.Point(58, 424);
            this.btn_Login_recConstrasena.Name = "btn_Login_recConstrasena";
            this.btn_Login_recConstrasena.Size = new System.Drawing.Size(378, 47);
            this.btn_Login_recConstrasena.TabIndex = 3;
            this.btn_Login_recConstrasena.Text = "Recuperar Constraseña";
            this.btn_Login_recConstrasena.UseVisualStyleBackColor = false;
            this.btn_Login_recConstrasena.Click += new System.EventHandler(this.btn_Login_recConstrasena_Click);
            // 
            // btn_login_clear
            // 
            this.btn_login_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login_clear.FlatAppearance.BorderSize = 0;
            this.btn_login_clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_login_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_clear.ForeColor = System.Drawing.Color.White;
            this.btn_login_clear.Location = new System.Drawing.Point(58, 473);
            this.btn_login_clear.Name = "btn_login_clear";
            this.btn_login_clear.Size = new System.Drawing.Size(378, 47);
            this.btn_login_clear.TabIndex = 4;
            this.btn_login_clear.Text = "Limpiar";
            this.btn_login_clear.UseVisualStyleBackColor = false;
            this.btn_login_clear.Click += new System.EventHandler(this.btn_login_clear_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_login_password.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.ForeColor = System.Drawing.Color.White;
            this.txt_login_password.Location = new System.Drawing.Point(105, 285);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(331, 30);
            this.txt_login_password.TabIndex = 1;
            this.txt_login_password.UseSystemPasswordChar = true;
            // 
            // txt_login_Nombre
            // 
            this.txt_login_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.txt_login_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_login_Nombre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_login_Nombre.Location = new System.Drawing.Point(96, 195);
            this.txt_login_Nombre.Name = "txt_login_Nombre";
            this.txt_login_Nombre.Size = new System.Drawing.Size(331, 30);
            this.txt_login_Nombre.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_login.Location = new System.Drawing.Point(58, 361);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(378, 47);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Iniciar Sesion";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(58, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 3);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(58, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 3);
            this.panel1.TabIndex = 12;
            // 
            // tb_RecContra
            // 
            this.tb_RecContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.tb_RecContra.Controls.Add(this.btn_RecConAceptar);
            this.tb_RecContra.Controls.Add(this.btn_volver);
            this.tb_RecContra.Controls.Add(this.label102);
            this.tb_RecContra.Controls.Add(this.txt_email);
            this.tb_RecContra.Controls.Add(this.panel3);
            this.tb_RecContra.Controls.Add(this.pictureBox1);
            this.tb_RecContra.Location = new System.Drawing.Point(4, 14);
            this.tb_RecContra.Name = "tb_RecContra";
            this.tb_RecContra.Padding = new System.Windows.Forms.Padding(3);
            this.tb_RecContra.Size = new System.Drawing.Size(498, 533);
            this.tb_RecContra.TabIndex = 1;
            // 
            // btn_RecConAceptar
            // 
            this.btn_RecConAceptar.BackColor = System.Drawing.Color.White;
            this.btn_RecConAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecConAceptar.FlatAppearance.BorderSize = 0;
            this.btn_RecConAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecConAceptar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecConAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_RecConAceptar.Location = new System.Drawing.Point(58, 331);
            this.btn_RecConAceptar.Name = "btn_RecConAceptar";
            this.btn_RecConAceptar.Size = new System.Drawing.Size(378, 47);
            this.btn_RecConAceptar.TabIndex = 2;
            this.btn_RecConAceptar.Text = "Aceptar";
            this.btn_RecConAceptar.UseVisualStyleBackColor = false;
            this.btn_RecConAceptar.Click += new System.EventHandler(this.btn_RecConAceptar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(13, 472);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(72, 62);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.ForeColor = System.Drawing.Color.White;
            this.label102.Location = new System.Drawing.Point(53, 135);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(385, 25);
            this.label102.TabIndex = 119;
            this.label102.Text = "Por favor digite su correo electronico";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(105, 236);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(331, 40);
            this.txt_email.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(58, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 3);
            this.panel3.TabIndex = 15;
            // 
            // tb_IngresoCont
            // 
            this.tb_IngresoCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.tb_IngresoCont.Controls.Add(this.label2);
            this.tb_IngresoCont.Controls.Add(this.txt_contraseña2);
            this.tb_IngresoCont.Controls.Add(this.panel5);
            this.tb_IngresoCont.Controls.Add(this.btn_volverAgregarContraseña);
            this.tb_IngresoCont.Controls.Add(this.btn_agregarContraseña);
            this.tb_IngresoCont.Controls.Add(this.label1);
            this.tb_IngresoCont.Controls.Add(this.txt_contraseña);
            this.tb_IngresoCont.Controls.Add(this.panel4);
            this.tb_IngresoCont.Location = new System.Drawing.Point(4, 14);
            this.tb_IngresoCont.Name = "tb_IngresoCont";
            this.tb_IngresoCont.Size = new System.Drawing.Size(498, 562);
            this.tb_IngresoCont.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 129;
            this.label2.Text = "Digitela de nuevo";
            // 
            // txt_contraseña2
            // 
            this.txt_contraseña2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.txt_contraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña2.ForeColor = System.Drawing.Color.White;
            this.txt_contraseña2.Location = new System.Drawing.Point(58, 272);
            this.txt_contraseña2.Multiline = true;
            this.txt_contraseña2.Name = "txt_contraseña2";
            this.txt_contraseña2.Size = new System.Drawing.Size(375, 40);
            this.txt_contraseña2.TabIndex = 126;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(58, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 3);
            this.panel5.TabIndex = 128;
            // 
            // btn_agregarContraseña
            // 
            this.btn_agregarContraseña.BackColor = System.Drawing.Color.White;
            this.btn_agregarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregarContraseña.FlatAppearance.BorderSize = 0;
            this.btn_agregarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarContraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_agregarContraseña.Location = new System.Drawing.Point(58, 338);
            this.btn_agregarContraseña.Name = "btn_agregarContraseña";
            this.btn_agregarContraseña.Size = new System.Drawing.Size(378, 47);
            this.btn_agregarContraseña.TabIndex = 121;
            this.btn_agregarContraseña.Text = "Aceptar";
            this.btn_agregarContraseña.UseVisualStyleBackColor = false;
            this.btn_agregarContraseña.Click += new System.EventHandler(this.btn_agregarContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 124;
            this.label1.Text = "Digite su nueva contraseña aquí";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_contraseña.Location = new System.Drawing.Point(58, 132);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(375, 40);
            this.txt_contraseña.TabIndex = 120;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(58, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 3);
            this.panel4.TabIndex = 123;
            // 
            // btn_Login_close
            // 
            this.btn_Login_close.FlatAppearance.BorderSize = 0;
            this.btn_Login_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_close.Image = global::Plantilla_Diseño_2.Properties.Resources.close_ico;
            this.btn_Login_close.Location = new System.Drawing.Point(433, 0);
            this.btn_Login_close.Name = "btn_Login_close";
            this.btn_Login_close.Size = new System.Drawing.Size(59, 35);
            this.btn_Login_close.TabIndex = 1;
            this.btn_Login_close.UseVisualStyleBackColor = true;
            this.btn_Login_close.Click += new System.EventHandler(this.btn_Login_close_Click);
            // 
            // pb_Login_LogoRes
            // 
            this.pb_Login_LogoRes.BackColor = System.Drawing.Color.Transparent;
            this.pb_Login_LogoRes.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_Login_LogoRes.ErrorImage")));
            this.pb_Login_LogoRes.Image = global::Plantilla_Diseño_2.Properties.Resources.Restaurant_ico;
            this.pb_Login_LogoRes.Location = new System.Drawing.Point(58, 6);
            this.pb_Login_LogoRes.Name = "pb_Login_LogoRes";
            this.pb_Login_LogoRes.Size = new System.Drawing.Size(378, 130);
            this.pb_Login_LogoRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Login_LogoRes.TabIndex = 15;
            this.pb_Login_LogoRes.TabStop = false;
            // 
            // pb_Login_Password
            // 
            this.pb_Login_Password.BackColor = System.Drawing.Color.Transparent;
            this.pb_Login_Password.Image = global::Plantilla_Diseño_2.Properties.Resources.lock_ico;
            this.pb_Login_Password.Location = new System.Drawing.Point(58, 290);
            this.pb_Login_Password.Name = "pb_Login_Password";
            this.pb_Login_Password.Size = new System.Drawing.Size(32, 29);
            this.pb_Login_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_Password.TabIndex = 10;
            this.pb_Login_Password.TabStop = false;
            // 
            // pb_Login_User
            // 
            this.pb_Login_User.BackColor = System.Drawing.Color.Transparent;
            this.pb_Login_User.Image = global::Plantilla_Diseño_2.Properties.Resources.login_ico;
            this.pb_Login_User.Location = new System.Drawing.Point(58, 195);
            this.pb_Login_User.Name = "pb_Login_User";
            this.pb_Login_User.Size = new System.Drawing.Size(32, 31);
            this.pb_Login_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_User.TabIndex = 8;
            this.pb_Login_User.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(58, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volverAgregarContraseña
            // 
            this.btn_volverAgregarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverAgregarContraseña.FlatAppearance.BorderSize = 0;
            this.btn_volverAgregarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_volverAgregarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volverAgregarContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volverAgregarContraseña.ForeColor = System.Drawing.Color.White;
            this.btn_volverAgregarContraseña.Image = global::Plantilla_Diseño_2.Properties.Resources.volver_ico;
            this.btn_volverAgregarContraseña.Location = new System.Drawing.Point(13, 472);
            this.btn_volverAgregarContraseña.Name = "btn_volverAgregarContraseña";
            this.btn_volverAgregarContraseña.Size = new System.Drawing.Size(72, 62);
            this.btn_volverAgregarContraseña.TabIndex = 125;
            this.btn_volverAgregarContraseña.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_volverAgregarContraseña.UseVisualStyleBackColor = false;
            this.btn_volverAgregarContraseña.Click += new System.EventHandler(this.btn_volverAgregarContraseña_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 586);
            this.Controls.Add(this.pn_cerrar);
            this.Controls.Add(this.tb_Login_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Inicio de Sesion";
            this.pn_cerrar.ResumeLayout(false);
            this.tb_Login_Main.ResumeLayout(false);
            this.tb_InicioSesion.ResumeLayout(false);
            this.tb_InicioSesion.PerformLayout();
            this.tb_RecContra.ResumeLayout(false);
            this.tb_RecContra.PerformLayout();
            this.tb_IngresoCont.ResumeLayout(false);
            this.tb_IngresoCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_LogoRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_cerrar;
        private System.Windows.Forms.Button btn_Login_close;
        private System.Windows.Forms.TabControl tb_Login_Main;
        private System.Windows.Forms.TabPage tb_InicioSesion;
        private System.Windows.Forms.Button btn_Login_recConstrasena;
        private System.Windows.Forms.PictureBox pb_Login_LogoRes;
        private System.Windows.Forms.Button btn_login_clear;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_Nombre;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Login_Password;
        private System.Windows.Forms.PictureBox pb_Login_User;
        private System.Windows.Forms.TabPage tb_RecContra;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_RecConAceptar;
        private System.Windows.Forms.TabPage tb_IngresoCont;
        private System.Windows.Forms.TextBox txt_contraseña2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_volverAgregarContraseña;
        private System.Windows.Forms.Button btn_agregarContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}