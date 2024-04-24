using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPizzaFinal
{
    public partial class Form1 : Form
    {
        //SE ESTABLECE LA CONEXI�N CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";

        public Form1()
        {

            InitializeComponent();
        }

        frmMenu Menu = new frmMenu();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContrase�a.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //COMPARA EL TIPO DE ROL SI EL USUARIO Y CONTRASE�A SON IGUALES
                string query = "SELECT tipo_rol FROM usuario WHERE nombre = @Username AND contrase�a = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                //SE ABRE LA CONEXI�N
                connection.Open();
                string tipoRol = (string)command.ExecuteScalar();
                
                if (tipoRol != null)
                {
                    //SE ESTABLECE LA CONDICI�N PARA VERIFICAR QUE EL USUARIO QUE INGRESA TIENE ROL DE ADMIN, SI ES ASI, ABRE EL MEN� DE ADMINISTRADOR
                    if (tipoRol.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        frmMenu menuForm = new frmMenu();
                        menuForm.Show();

                        // Verificar el rol del usuario y hacer visible el bot�n correspondiente
                        if (tipoRol.Equals("admin", StringComparison.OrdinalIgnoreCase))
                        {
                            menuForm.MostrarBotonAdministrar();
                        }

                    }
                    //SI TIENE OTRO ROL SE ABRE EL MEN� PRINCIPAL
                    else
                    {
                        frmMenu menuForm = new frmMenu();
                        menuForm.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
                }
            }
  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
