using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPizzaFinal
{
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }

        frmIngresarDinero efec = new frmIngresarDinero();
        frmTarjeta TARJE = new frmTarjeta();
        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            efec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TARJE.Show();
        }
    }
}
