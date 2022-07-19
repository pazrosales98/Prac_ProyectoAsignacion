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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f2 = new frmAulas();
            f2.FormClosed += (s,args) => this.Close();
            f2.Show();
        }

        private void btnAuditorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fAu = new frmAuditorios();
            fAu.FormClosed += (s, args) => this.Close();
            fAu.Show();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fLab = new frmAulas();
            fLab.FormClosed += (s, args) => this.Close();
            fLab.Show();
        }
    }
}
