namespace Prac_ProyectoAsignacion
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btnAuditorios = new System.Windows.Forms.Button();
            this.btnLab = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16F);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universidad Católica de Honduras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(190, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campus San Pedro y San Pablo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(143, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bienvenido al Sistema de Asignaciones\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(211, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "¿Qué desea asignar?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAulas
            // 
            this.btnAulas.Location = new System.Drawing.Point(48, 228);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(131, 79);
            this.btnAulas.TabIndex = 5;
            this.btnAulas.Text = "Aulas";
            this.btnAulas.UseVisualStyleBackColor = true;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnAuditorios
            // 
            this.btnAuditorios.Location = new System.Drawing.Point(240, 228);
            this.btnAuditorios.Name = "btnAuditorios";
            this.btnAuditorios.Size = new System.Drawing.Size(131, 79);
            this.btnAuditorios.TabIndex = 6;
            this.btnAuditorios.Text = "Auditorios";
            this.btnAuditorios.UseVisualStyleBackColor = true;
            this.btnAuditorios.Click += new System.EventHandler(this.btnAuditorios_Click);
            // 
            // btnLab
            // 
            this.btnLab.Location = new System.Drawing.Point(435, 228);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(131, 79);
            this.btnLab.TabIndex = 7;
            this.btnLab.Text = "Laboratorios";
            this.btnLab.UseVisualStyleBackColor = true;
            this.btnLab.Click += new System.EventHandler(this.btnLab_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(216, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 79);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir del Programa";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Prac_ProyectoAsignacion.Properties.Resources.UNICAH_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(629, 442);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.btnAuditorios);
            this.Controls.Add(this.btnAulas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Asignaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnAuditorios;
        private System.Windows.Forms.Button btnLab;
        private System.Windows.Forms.Button btnSalir;
    }
}

