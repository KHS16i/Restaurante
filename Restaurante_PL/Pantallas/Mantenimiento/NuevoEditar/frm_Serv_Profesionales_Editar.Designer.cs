
namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    partial class frm_Serv_Profesionales_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Serv_Profesionales_Editar));
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.cbx_Puestos = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Horas_Laboradas = new System.Windows.Forms.TextBox();
            this.txt_Serv_Recibido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.dtp_Fecha_Servicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Monto_Cancelado = new System.Windows.Forms.TextBox();
            this.cbx_Empleado_Aut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Main_min = new System.Windows.Forms.Button();
            this.btn_Main_close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.Color.White;
            this.btn_logOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_logOut.Image")));
            this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logOut.Location = new System.Drawing.Point(41, 520);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(68, 73);
            this.btn_logOut.TabIndex = 10;
            this.btn_logOut.Text = "Salir";
            this.btn_logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Home.Location = new System.Drawing.Point(467, 520);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(90, 73);
            this.btn_Home.TabIndex = 9;
            this.btn_Home.Text = "Modificar";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // cbx_Puestos
            // 
            this.cbx_Puestos.FormattingEnabled = true;
            this.cbx_Puestos.Location = new System.Drawing.Point(357, 452);
            this.cbx_Puestos.Name = "cbx_Puestos";
            this.cbx_Puestos.Size = new System.Drawing.Size(200, 21);
            this.cbx_Puestos.TabIndex = 8;
            this.cbx_Puestos.Tag = "";
            this.cbx_Puestos.Text = "Puestos disponibles a elegir";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(357, 164);
            this.txt_ID.MaxLength = 20;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(200, 20);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // txt_Horas_Laboradas
            // 
            this.txt_Horas_Laboradas.Location = new System.Drawing.Point(357, 212);
            this.txt_Horas_Laboradas.MaxLength = 4;
            this.txt_Horas_Laboradas.Name = "txt_Horas_Laboradas";
            this.txt_Horas_Laboradas.Size = new System.Drawing.Size(200, 20);
            this.txt_Horas_Laboradas.TabIndex = 3;
            this.txt_Horas_Laboradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Horas_Laboradas_KeyPress);
            // 
            // txt_Serv_Recibido
            // 
            this.txt_Serv_Recibido.Location = new System.Drawing.Point(357, 308);
            this.txt_Serv_Recibido.Multiline = true;
            this.txt_Serv_Recibido.Name = "txt_Serv_Recibido";
            this.txt_Serv_Recibido.Size = new System.Drawing.Size(200, 42);
            this.txt_Serv_Recibido.TabIndex = 5;
            this.txt_Serv_Recibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Serv_Recibido_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(357, 116);
            this.txt_Nombre.MaxLength = 50;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // dtp_Fecha_Servicio
            // 
            this.dtp_Fecha_Servicio.Location = new System.Drawing.Point(357, 404);
            this.dtp_Fecha_Servicio.Name = "dtp_Fecha_Servicio";
            this.dtp_Fecha_Servicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Servicio.TabIndex = 7;
            this.dtp_Fecha_Servicio.CloseUp += new System.EventHandler(this.dtp_Fecha_Servicio_CloseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Puesto Desempeñado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servicio recibido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha del servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Empleado que autoriza el registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horas laboradas";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(37, 164);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(122, 20);
            this.A.TabIndex = 0;
            this.A.Text = "Identificación ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 73);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modificar Servicio Profesional";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Monto_Cancelado
            // 
            this.txt_Monto_Cancelado.Location = new System.Drawing.Point(357, 356);
            this.txt_Monto_Cancelado.MaxLength = 12;
            this.txt_Monto_Cancelado.Name = "txt_Monto_Cancelado";
            this.txt_Monto_Cancelado.Size = new System.Drawing.Size(200, 20);
            this.txt_Monto_Cancelado.TabIndex = 6;
            this.txt_Monto_Cancelado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_Cancelado_KeyPress);
            // 
            // cbx_Empleado_Aut
            // 
            this.cbx_Empleado_Aut.Enabled = false;
            this.cbx_Empleado_Aut.FormattingEnabled = true;
            this.cbx_Empleado_Aut.Location = new System.Drawing.Point(357, 258);
            this.cbx_Empleado_Aut.Name = "cbx_Empleado_Aut";
            this.cbx_Empleado_Aut.Size = new System.Drawing.Size(200, 21);
            this.cbx_Empleado_Aut.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto cancelado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.btn_Main_min);
            this.panel2.Controls.Add(this.btn_Main_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 36);
            this.panel2.TabIndex = 91;
            // 
            // btn_Main_min
            // 
            this.btn_Main_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Main_min.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Main_min.FlatAppearance.BorderSize = 0;
            this.btn_Main_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Main_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Main_min.Image")));
            this.btn_Main_min.Location = new System.Drawing.Point(441, 0);
            this.btn_Main_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_min.Name = "btn_Main_min";
            this.btn_Main_min.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_min.TabIndex = 11;
            this.btn_Main_min.UseVisualStyleBackColor = false;
            // 
            // btn_Main_close
            // 
            this.btn_Main_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Main_close.FlatAppearance.BorderSize = 0;
            this.btn_Main_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Main_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Main_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Main_close.Image")));
            this.btn_Main_close.Location = new System.Drawing.Point(550, 0);
            this.btn_Main_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_close.Name = "btn_Main_close";
            this.btn_Main_close.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_close.TabIndex = 12;
            this.btn_Main_close.UseVisualStyleBackColor = false;
            this.btn_Main_close.Click += new System.EventHandler(this.btn_Main_close_Click);
            // 
            // frm_Serv_Profesionales_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(609, 589);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Empleado_Aut);
            this.Controls.Add(this.txt_Monto_Cancelado);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.cbx_Puestos);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Horas_Laboradas);
            this.Controls.Add(this.txt_Serv_Recibido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.dtp_Fecha_Servicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Serv_Profesionales_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Serv_Profesionales_Nuevo";
            this.Load += new System.EventHandler(this.frm_Serv_Profesionales_Editar_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.ComboBox cbx_Puestos;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Horas_Laboradas;
        private System.Windows.Forms.TextBox txt_Serv_Recibido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Servicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Monto_Cancelado;
        private System.Windows.Forms.ComboBox cbx_Empleado_Aut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Main_min;
        private System.Windows.Forms.Button btn_Main_close;
    }
}