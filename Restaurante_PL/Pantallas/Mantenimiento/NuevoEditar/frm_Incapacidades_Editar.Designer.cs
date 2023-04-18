
namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    partial class frm_Incapacidades_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Incapacidades_Editar));
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Num_Orden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.dtp_Final_Periodo = new System.Windows.Forms.DateTimePicker();
            this.dtp_Inicio_Periodo = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Main_min = new System.Windows.Forms.Button();
            this.btn_Main_close = new System.Windows.Forms.Button();
            this.cbx_Empleado_modifica = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(52, 183);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(224, 20);
            this.A.TabIndex = 0;
            this.A.Text = "Fecha de inicio del periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha final del periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripción";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(372, 327);
            this.txt_Descripcion.MaxLength = 60;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(200, 53);
            this.txt_Descripcion.TabIndex = 5;
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contacto_Emer_Empleado_KeyPress);
            // 
            // txt_Num_Orden
            // 
            this.txt_Num_Orden.Location = new System.Drawing.Point(372, 279);
            this.txt_Num_Orden.MaxLength = 10;
            this.txt_Num_Orden.Name = "txt_Num_Orden";
            this.txt_Num_Orden.Size = new System.Drawing.Size(200, 20);
            this.txt_Num_Orden.TabIndex = 4;
            this.txt_Num_Orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num_Orden_KeyPress);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(625, 73);
            this.label4.TabIndex = 0;
            this.label4.Text = "Editar Incapacidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.btn_logOut.Location = new System.Drawing.Point(56, 400);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(68, 73);
            this.btn_logOut.TabIndex = 7;
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
            this.btn_Home.Location = new System.Drawing.Point(485, 400);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(90, 73);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Text = "Editar";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // dtp_Final_Periodo
            // 
            this.dtp_Final_Periodo.Location = new System.Drawing.Point(372, 231);
            this.dtp_Final_Periodo.MaxDate = new System.DateTime(2072, 12, 31, 0, 0, 0, 0);
            this.dtp_Final_Periodo.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_Final_Periodo.Name = "dtp_Final_Periodo";
            this.dtp_Final_Periodo.Size = new System.Drawing.Size(200, 20);
            this.dtp_Final_Periodo.TabIndex = 3;
            this.dtp_Final_Periodo.CloseUp += new System.EventHandler(this.dtp_Final_Periodo_CloseUp);
            // 
            // dtp_Inicio_Periodo
            // 
            this.dtp_Inicio_Periodo.Location = new System.Drawing.Point(372, 183);
            this.dtp_Inicio_Periodo.MaxDate = new System.DateTime(2072, 12, 31, 0, 0, 0, 0);
            this.dtp_Inicio_Periodo.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_Inicio_Periodo.Name = "dtp_Inicio_Periodo";
            this.dtp_Inicio_Periodo.Size = new System.Drawing.Size(200, 20);
            this.dtp_Inicio_Periodo.TabIndex = 2;
            this.dtp_Inicio_Periodo.CloseUp += new System.EventHandler(this.dtp_Inicio_Periodo_CloseUp);
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
            this.panel2.Size = new System.Drawing.Size(625, 36);
            this.panel2.TabIndex = 73;
            // 
            // btn_Main_min
            // 
            this.btn_Main_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Main_min.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Main_min.FlatAppearance.BorderSize = 0;
            this.btn_Main_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Main_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Main_min.Image")));
            this.btn_Main_min.Location = new System.Drawing.Point(457, 0);
            this.btn_Main_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_min.Name = "btn_Main_min";
            this.btn_Main_min.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_min.TabIndex = 8;
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
            this.btn_Main_close.Location = new System.Drawing.Point(566, 0);
            this.btn_Main_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_close.Name = "btn_Main_close";
            this.btn_Main_close.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_close.TabIndex = 9;
            this.btn_Main_close.UseVisualStyleBackColor = false;
            this.btn_Main_close.Click += new System.EventHandler(this.btn_Main_close_Click);
            // 
            // cbx_Empleado_modifica
            // 
            this.cbx_Empleado_modifica.Enabled = false;
            this.cbx_Empleado_modifica.FormattingEnabled = true;
            this.cbx_Empleado_modifica.Location = new System.Drawing.Point(372, 133);
            this.cbx_Empleado_modifica.Name = "cbx_Empleado_modifica";
            this.cbx_Empleado_modifica.Size = new System.Drawing.Size(200, 21);
            this.cbx_Empleado_modifica.TabIndex = 74;
            // 
            // frm_Incapacidades_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(625, 535);
            this.Controls.Add(this.cbx_Empleado_modifica);
            this.Controls.Add(this.dtp_Final_Periodo);
            this.Controls.Add(this.dtp_Inicio_Periodo);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Num_Orden);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Incapacidades_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Incapacidad";
            this.Load += new System.EventHandler(this.frm_Incapacidades_Editar_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Num_Orden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.DateTimePicker dtp_Final_Periodo;
        private System.Windows.Forms.DateTimePicker dtp_Inicio_Periodo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Main_min;
        private System.Windows.Forms.Button btn_Main_close;
        private System.Windows.Forms.ComboBox cbx_Empleado_modifica;
    }
}
