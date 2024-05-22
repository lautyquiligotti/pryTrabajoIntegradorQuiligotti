using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoIntegradorQuiligotti
{
    public partial class frmLocales : Form
    {
        public frmLocales()
        {
            InitializeComponent();
        }

        private void btnLocalQuenaken_Click(object sender, EventArgs e)
        {
            frmQuenaken Quenaken = new frmQuenaken();
            Quenaken.ShowDialog();
        }

        private void btnLocalOnas_Click(object sender, EventArgs e)
        {
            frmOnas Onas = new frmOnas();   
            Onas.ShowDialog();
        }

        private void btnLocalTobas_Click(object sender, EventArgs e)
        {
            frmTobas Tobas = new frmTobas();
            Tobas.ShowDialog();
        }
    }
}
