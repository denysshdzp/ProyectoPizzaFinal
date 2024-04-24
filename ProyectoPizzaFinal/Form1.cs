using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPizzaFinal
{
    public partial class Form1 : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";

        public Form1()
        {

            InitializeComponent();
        }

        frmMenu Menu = new frmMenu();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //COMPARA EL TIPO DE ROL SI EL USUARIO Y CONTRASEÑA SON IGUALES
                string query = "SELECT tipo_rol FROM usuario WHERE nombre = @Username AND contraseña = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                //SE ABRE LA CONEXIÓN
                connection.Open();
                string tipoRol = (string)command.ExecuteScalar();
                
                if (tipoRol != null)
                {
                    //SE ESTABLECE LA CONDICIÓN PARA VERIFICAR QUE EL USUARIO QUE INGRESA TIENE ROL DE ADMIN, SI ES ASI, ABRE EL MENÚ DE ADMINISTRADOR
                    if (tipoRol.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        frmMenu menuForm = new frmMenu();
                        menuForm.Show();

                        // Verificar el rol del usuario y hacer visible el botón correspondiente
                        if (tipoRol.Equals("admin", StringComparison.OrdinalIgnoreCase))
                        {
                            menuForm.MostrarBotonAdministrar();
                        }

                    }
                    //SI TIENE OTRO ROL SE ABRE EL MENÚ PRINCIPAL
                    else
                    {
                        frmMenu menuForm = new frmMenu();
                        menuForm.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                }
            }
  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
