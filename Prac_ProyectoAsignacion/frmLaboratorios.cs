using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_ProyectoAsignacion
{
    public partial class frmLaboratorios : Form
    {
        public frmLaboratorios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f5 = new frmMenuPrincipal();
            f5.FormClosed += (s, args) => this.Close();
            f5.Show();
        }
    }
}
