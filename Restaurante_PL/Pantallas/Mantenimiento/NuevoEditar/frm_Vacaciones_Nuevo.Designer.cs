
namespace Plantilla_Diseño_2.Pantallas.Mantenimiento.NuevoEditar
{
    partial class frm_Vacaciones_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vacaciones_Nuevo));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Dias_Disponibles = new System.Windows.Forms.TextBox();
            this.txt_Dias_Nuevo_Periodo = new System.Windows.Forms.TextBox();
            this.dtp_Fecha_Inicio_Periodo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Main_min = new System.Windows.Forms.Button();
            this.btn_Main_close = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 73);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registrar Periodo de Vacaciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Dias_Disponibles
            // 
            this.txt_Dias_Disponibles.Location = new System.Drawing.Point(310, 171);
            this.txt_Dias_Disponibles.MaxLength = 2;
            this.txt_Dias_Disponibles.Name = "txt_Dias_Disponibles";
            this.txt_Dias_Disponibles.ReadOnly = true;
            this.txt_Dias_Disponibles.Size = new System.Drawing.Size(200, 20);
            this.txt_Dias_Disponibles.TabIndex = 2;
            // 
            // txt_Dias_Nuevo_Periodo
            // 
            this.txt_Dias_Nuevo_Periodo.Location = new System.Drawing.Point(312, 226);
            this.txt_Dias_Nuevo_Periodo.MaxLength = 2;
            this.txt_Dias_Nuevo_Periodo.Name = "txt_Dias_Nuevo_Periodo";
            this.txt_Dias_Nuevo_Periodo.Size = new System.Drawing.Size(200, 20);
            this.txt_Dias_Nuevo_Periodo.TabIndex = 3;
            this.txt_Dias_Nuevo_Periodo.Text = "Falta esta validacion";
            this.txt_Dias_Nuevo_Periodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dias_Nuevo_Periodo_KeyPress);
            // 
            // dtp_Fecha_Inicio_Periodo
            // 
            this.dtp_Fecha_Inicio_Periodo.Location = new System.Drawing.Point(312, 281);
            this.dtp_Fecha_Inicio_Periodo.Name = "dtp_Fecha_Inicio_Periodo";
            this.dtp_Fecha_Inicio_Periodo.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_Inicio_Periodo.TabIndex = 4;
            this.dtp_Fecha_Inicio_Periodo.CloseUp += new System.EventHandler(this.dtp_Fecha_Inicio_Periodo_CloseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de inicio del periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Días del nuevo periodo";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(40, 169);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(143, 20);
            this.A.TabIndex = 0;
            this.A.Text = "Días Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 115);
            this.comboBox1.MaxLength = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Empleado a elegir";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
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
            this.panel2.Size = new System.Drawing.Size(569, 36);
            this.panel2.TabIndex = 68;
            // 
            // btn_Main_min
            // 
            this.btn_Main_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Main_min.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Main_min.FlatAppearance.BorderSize = 0;
            this.btn_Main_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Main_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Main_min.Image")));
            this.btn_Main_min.Location = new System.Drawing.Point(401, 0);
            this.btn_Main_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_min.Name = "btn_Main_min";
            this.btn_Main_min.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_min.TabIndex = 6;
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
            this.btn_Main_close.Location = new System.Drawing.Point(510, 0);
            this.btn_Main_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main_close.Name = "btn_Main_close";
            this.btn_Main_close.Size = new System.Drawing.Size(55, 36);
            this.btn_Main_close.TabIndex = 5;
            this.btn_Main_close.UseVisualStyleBackColor = false;
            this.btn_Main_close.Click += new System.EventHandler(this.btn_Main_close_Click);
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
            this.btn_logOut.Location = new System.Drawing.Point(44, 332);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(68, 73);
            this.btn_logOut.TabIndex = 6;
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
            this.btn_Home.Location = new System.Drawing.Point(381, 332);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(129, 73);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Registrar Periodo";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // frm_Vacaciones_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(569, 441);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.txt_Dias_Disponibles);
            this.Controls.Add(this.txt_Dias_Nuevo_Periodo);
            this.Controls.Add(this.dtp_Fecha_Inicio_Periodo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Vacaciones_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                ";
            this.Load += new System.EventHandler(this.frm_Vacaciones_Nuevo_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TextBox txt_Dias_Disponibles;
        private System.Windows.Forms.TextBox txt_Dias_Nuevo_Periodo;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Inicio_Periodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Main_min;
        private System.Windows.Forms.Button btn_Main_close;
    }
}
