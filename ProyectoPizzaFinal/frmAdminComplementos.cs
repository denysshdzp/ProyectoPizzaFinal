using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPizzaFinal
{
    public partial class frmAdminComplementos : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";
        public frmAdminComplementos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idComplemento;
            //VALIDA QUE EL ID SEA NUMERO ENTERO
            if (!int.TryParse(txtIdComplemento.Text, out idComplemento))
            {
                MessageBox.Show("El ID del complemento debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            //VALIDA QUE EL PRECIO SEA NUMERO DECIMAL
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio del complemento debe ser un número decimal válido.");
                return;
            }

            //VALIDA QUE NO QUEDEN CAMPOS EN BLANCO
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(txtIdComplemento.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //METODO DE INSERTAR A LA BASE DE DATOS
                    string query = "INSERT INTO complementos (idcomplemento, nombre, descripcion, precio) " +
                                   "VALUES (@IdComplemento, @Nombre, @Descripcion, @Precio)";
                    //SE EJECUTA EL QUERY
                    SqlCommand command = new SqlCommand(query, connection);
                    //SE AGREGAN LOS VALORES
                    command.Parameters.AddWithValue("@IdComplemento", idComplemento);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    //SE ABRE LA CONEXION
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    //VALIDA SI SE AGREGARON LOS DATOS O NO
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Complemento agregado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el complemento.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //MUESTRA LOS DATOS EN LA TABLA
        private void ActualizarDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM complementos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewComplementos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }

        //LIMPIA LOS CAMPOS
        private void LimpiarCampos()
        {
            txtIdComplemento.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idComplemento;
            if (!int.TryParse(txtIdComplemento.Text, out idComplemento))
            {
                MessageBox.Show("El ID del complemento debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio del complemento debe ser un número decimal válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE complementos SET nombre = @Nombre, descripcion = @Descripcion, precio = @Precio WHERE idcomplemento = @IdComplemento";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdComplemento", idComplemento);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Complemento modificado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el complemento. No se encontró el complemento con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdministrador frmMenuAdmin = new frmMenuAdministrador();
            frmMenuAdmin.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idComplemento;
            if (!int.TryParse(txtIdComplemento.Text, out idComplemento))
            {
                MessageBox.Show("El ID del complemento debe ser un número entero.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM complementos WHERE idcomplemento = @IdComplemento";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdComplemento", idComplemento);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Complemento eliminado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el complemento. No se encontró el complemento con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
