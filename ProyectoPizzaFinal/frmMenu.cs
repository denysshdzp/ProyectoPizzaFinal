using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPizzaFinal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        //Codigo para abrir las formas en el menu principal
        public void AbrirFormEnPanel(object formhija)
        {
            if (this.pContenido.Controls.Count > 0)
                this.pContenido.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenido.Controls.Add(fh);
            this.pContenido.Tag = fh;
            fh.Show();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Llamado a las otras formas
        frmPizzaIndi pizzaIndi = new frmPizzaIndi();
        frmComplementos complementos = new frmComplementos();
        frmCombos combos = new frmCombos();
        frmPedidosPendientes PedidosPendientes = new frmPedidosPendientes();
        frmOrden PAGO = new frmOrden();
        frmCancelarOrden CANCELAR = new frmCancelarOrden();
        frmPromocion promo = new frmPromocion();
        frmInforme info = new frmInforme();
        frmAgregarMenuCombo mod = new frmAgregarMenuCombo();
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new frmPizzaIndi());
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPizzaIndi());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnComplemento_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmComplementos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCombos());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPedidosPendientes());
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PAGO.Show();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            CANCELAR.Show();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPromocion());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInforme());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmAgregarMenuCombo());
        }
    }
}
