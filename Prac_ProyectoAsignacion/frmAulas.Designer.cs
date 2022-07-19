namespace Prac_ProyectoAsignacion
{
    partial class frmAulas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAulas));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPInicio = new System.Windows.Forms.DateTimePicker();
            this.dTPFin = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboNombreMaestro = new System.Windows.Forms.ComboBox();
            this.maestrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasBDDataSet = new Prac_ProyectoAsignacion.AulasBDDataSet();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasTableAdapter = new Prac_ProyectoAsignacion.AulasBDDataSetTableAdapters.AulasTableAdapter();
            this.maestrosClasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestrosClasesTableAdapter = new Prac_ProyectoAsignacion.AulasBDDataSetTableAdapters.MaestrosClasesTableAdapter();
            this.maestrosTableAdapter = new Prac_ProyectoAsignacion.AulasBDDataSetTableAdapters.MaestrosTableAdapter();
            this.maestrosMaestrosClasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cboNombreClase = new System.Windows.Forms.ComboBox();
            this.cboCodigoAula = new System.Windows.Forms.ComboBox();
            this.aulasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasesTableAdapter = new Prac_ProyectoAsignacion.AulasBDDataSetTableAdapters.ClasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosClasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosMaestrosClasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(487, 405);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(146, 71);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar al Menú Principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14F);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(133, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sistema de Asignación de Aulas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código de Aula:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de Clase:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(5, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre de Maestro:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Horario Deseado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(300, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "a";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTPInicio
            // 
            this.dTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPInicio.Location = new System.Drawing.Point(166, 262);
            this.dTPInicio.Name = "dTPInicio";
            this.dTPInicio.Size = new System.Drawing.Size(128, 30);
            this.dTPInicio.TabIndex = 21;
            // 
            // dTPFin
            // 
            this.dTPFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPFin.Location = new System.Drawing.Point(325, 261);
            this.dTPFin.Name = "dTPFin";
            this.dTPFin.Size = new System.Drawing.Size(128, 30);
            this.dTPFin.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 359);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 61);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Ingresar Datos";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboNombreMaestro
            // 
            this.cboNombreMaestro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.maestrosBindingSource, "Nombre", true));
            this.cboNombreMaestro.DataSource = this.maestrosBindingSource;
            this.cboNombreMaestro.DisplayMember = "Nombre";
            this.cboNombreMaestro.FormattingEnabled = true;
            this.cboNombreMaestro.Location = new System.Drawing.Point(178, 195);
            this.cboNombreMaestro.Name = "cboNombreMaestro";
            this.cboNombreMaestro.Size = new System.Drawing.Size(132, 31);
            this.cboNombreMaestro.TabIndex = 24;
            this.cboNombreMaestro.ValueMember = "Nombre";
            // 
            // maestrosBindingSource
            // 
            this.maestrosBindingSource.DataMember = "Maestros";
            this.maestrosBindingSource.DataSource = this.aulasBDDataSetBindingSource;
            // 
            // aulasBDDataSetBindingSource
            // 
            this.aulasBDDataSetBindingSource.DataSource = this.aulasBDDataSet;
            this.aulasBDDataSetBindingSource.Position = 0;
            // 
            // aulasBDDataSet
            // 
            this.aulasBDDataSet.DataSetName = "AulasBDDataSet";
            this.aulasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.aulasBDDataSetBindingSource;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // maestrosClasesBindingSource
            // 
            this.maestrosClasesBindingSource.DataMember = "MaestrosClases";
            this.maestrosClasesBindingSource.DataSource = this.aulasBDDataSetBindingSource;
            // 
            // maestrosClasesTableAdapter
            // 
            this.maestrosClasesTableAdapter.ClearBeforeFill = true;
            // 
            // maestrosTableAdapter
            // 
            this.maestrosTableAdapter.ClearBeforeFill = true;
            // 
            // maestrosMaestrosClasesBindingSource
            // 
            this.maestrosMaestrosClasesBindingSource.DataMember = "MaestrosMaestrosClases";
            this.maestrosMaestrosClasesBindingSource.DataSource = this.maestrosBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(25, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Días de Clase:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.checkedListBox1.Location = new System.Drawing.Point(166, 314);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(218, 154);
            this.checkedListBox1.TabIndex = 26;
            // 
            // cboNombreClase
            // 
            this.cboNombreClase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clasesBindingSource, "Descripcion", true));
            this.cboNombreClase.DataSource = this.clasesBindingSource;
            this.cboNombreClase.DisplayMember = "Descripcion";
            this.cboNombreClase.FormattingEnabled = true;
            this.cboNombreClase.Location = new System.Drawing.Point(178, 126);
            this.cboNombreClase.Name = "cboNombreClase";
            this.cboNombreClase.Size = new System.Drawing.Size(132, 31);
            this.cboNombreClase.TabIndex = 27;
            this.cboNombreClase.ValueMember = "Descripcion";
            // 
            // cboCodigoAula
            // 
            this.cboCodigoAula.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aulasBindingSource, "CodigoAula", true));
            this.cboCodigoAula.DataSource = this.aulasBindingSource1;
            this.cboCodigoAula.DisplayMember = "CodigoAula";
            this.cboCodigoAula.FormattingEnabled = true;
            this.cboCodigoAula.Location = new System.Drawing.Point(178, 67);
            this.cboCodigoAula.Name = "cboCodigoAula";
            this.cboCodigoAula.Size = new System.Drawing.Size(132, 31);
            this.cboCodigoAula.TabIndex = 28;
            this.cboCodigoAula.ValueMember = "CodigoAula";
            // 
            // aulasBindingSource1
            // 
            this.aulasBindingSource1.DataMember = "Aulas";
            this.aulasBindingSource1.DataSource = this.aulasBDDataSetBindingSource;
            // 
            // clasesBindingSource
            // 
            this.clasesBindingSource.DataMember = "Clases";
            this.clasesBindingSource.DataSource = this.aulasBDDataSetBindingSource;
            // 
            // clasesTableAdapter
            // 
            this.clasesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(646, 489);
            this.Controls.Add(this.cboCodigoAula);
            this.Controls.Add(this.cboNombreClase);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNombreMaestro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dTPFin);
            this.Controls.Add(this.dTPInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Open Sans", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Aulas";
            this.Load += new System.EventHandler(this.frmAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosClasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosMaestrosClasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPInicio;
        private System.Windows.Forms.DateTimePicker dTPFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboNombreMaestro;
        private System.Windows.Forms.BindingSource aulasBDDataSetBindingSource;
        private AulasBDDataSet aulasBDDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private AulasBDDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private System.Windows.Forms.BindingSource maestrosClasesBindingSource;
        private AulasBDDataSetTableAdapters.MaestrosClasesTableAdapter maestrosClasesTableAdapter;
        private System.Windows.Forms.BindingSource maestrosBindingSource;
        private AulasBDDataSetTableAdapters.MaestrosTableAdapter maestrosTableAdapter;
        private System.Windows.Forms.BindingSource maestrosMaestrosClasesBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cboNombreClase;
        private System.Windows.Forms.ComboBox cboCodigoAula;
        private System.Windows.Forms.BindingSource aulasBindingSource1;
        private System.Windows.Forms.BindingSource clasesBindingSource;
        private AulasBDDataSetTableAdapters.ClasesTableAdapter clasesTableAdapter;
    }
}