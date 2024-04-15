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
    public partial class frmMenuAdministrador : Form
    {
        public frmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            frmAdminPizzas frmPizzas = new frmAdminPizzas();
            frmPizzas.Show();
            this.Close();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            frmAdminCombos frmCombos = new frmAdminCombos();
            frmCombos.Show();
            this.Close();
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            frmAdminComplementos frmComplementos = new frmAdminComplementos();
            frmComplementos.Show();
            this.Close();
        }

        private void btnIngredienteExtra_Click(object sender, EventArgs e)
        {
            frmAdminIngredienteExtra frmIExtra = new frmAdminIngredienteExtra();
            frmIExtra.Show();
            this.Close();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            frmAdminPromociones frmProm = new frmAdminPromociones();
            frmProm.Show();
            this.Close();
        }
    }
}
