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
    public partial class frmQuenaken : Form
    {
        public frmQuenaken()
        {
            InitializeComponent();
        }

        private void frmQuenaken_Load(object sender, EventArgs e)
        {
            Graphics gra = pictureBox1.CreateGraphics();
            gra.DrawString("Asiento 1", new Font("Arial", 10), Brushes.Green, 10, 15);
            gra.DrawRectangle(Pens.Black, 10, 10, 58, 25);
            
        }
    }
}
