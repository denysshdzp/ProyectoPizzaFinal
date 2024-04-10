namespace ProyectoPizzaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmMenu Menu = new frmMenu();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Menu.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
