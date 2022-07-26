﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prac_ProyectoAsignacion
{
    public partial class frmAulas : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public frmAulas()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\andyr\Source\Repos\Prac_ProyectoAsignacion\Prac_ProyectoAsignacion\AulasBD.accdb";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f3 = new frmMenuPrincipal();
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }

        private void frmAulas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aulasBDDataSet.Clases' table. You can move, or remove it, as needed.
            this.clasesTableAdapter.Fill(this.aulasBDDataSet.Clases);
            // TODO: This line of code loads data into the 'aulasBDDataSet.Aulas' table. You can move, or remove it, as needed.
            this.aulasTableAdapter.Fill(this.aulasBDDataSet.Aulas);
            // TODO: This line of code loads data into the 'aulasBDDataSet.Maestros' table. You can move, or remove it, as needed.
            this.maestrosTableAdapter.Fill(this.aulasBDDataSet.Maestros);
            // TODO: This line of code loads data into the 'aulasBDDataSet.MaestrosClases' table. You can move, or remove it, as needed.
            this.maestrosClasesTableAdapter.Fill(this.aulasBDDataSet.MaestrosClases);
            // TODO: This line of code loads data into the 'aulasBDDataSet.Aulas' table. You can move, or remove it, as needed.
            this.aulasTableAdapter.Fill(this.aulasBDDataSet.Aulas);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); 
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                string GuardarDias = "";
                foreach(Object dias in cLBDias.SelectedItems){
                    GuardarDias += dias.ToString();
                   
                }
                MessageBox.Show(GuardarDias);
                //comm.CommandText = "insert into ClasesAsignaciones (CodAula,CodigoClase,CodMaestro,HoraInicio,HoraFin,Dia) " +
                // "values('" + cboCodigoAula.SelectedValue + "' ,'" + cboNombreClase.SelectedValue + "','" 
                // + cboNombreMaestro.SelectedValue + "','" + txtInicio.Text + "', '" + txtFin.Text + "', '"+ cLBDias.SelectedIndices+ "')";

                // comm.ExecuteNonQuery();
                MessageBox.Show("Clase asignada exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
