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
    public partial class frmAuditorios : Form
    {
        public frmAuditorios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4= new frmMenuPrincipal();
            f4.FormClosed += (s, args) => this.Close();
            f4.Show();
        }
    }
}
