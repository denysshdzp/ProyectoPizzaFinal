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
    public partial class frmAdminIngredienteExtra : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";
        public frmAdminIngredienteExtra()
        {
            InitializeComponent();
            ActualizarDataGridView();
            dataGridViewIngredienteExtra.SelectionChanged += dataGridViewIngredienteExtra_SelectionChanged;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idIngrediente;
            //VALIDA QUE EL ID SEA NUMERO ENTERO
            if (!int.TryParse(txtIdIngrediente.Text, out idIngrediente))
            {
                MessageBox.Show("El ID del ingrediente debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            decimal costo;
            //VALIDA QUE EL COSTO SEA NUMERO DECIMAL
            if (!decimal.TryParse(txtPrecio.Text, out costo))
            {
                MessageBox.Show("El costo del ingrediente debe ser un número decimal válido.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //METODO DE INSERTAR A LA BASE DE DATOS
                    string query = "INSERT INTO ingrediente_adicional (id, nombre, costo) " +
                                   "VALUES (@IdIngrediente, @Nombre, @Costo)";
                    //SE EJECUTA EL QUERY
                    SqlCommand command = new SqlCommand(query, connection);
                    //SE AGREGAN LOS VALORES
                    command.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Costo", costo);
                    //SE ABRE LA CONEXION
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    //VALIDA SI SE AGREGARON LOS DATOS O NO
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingrediente adicional agregado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el ingrediente adicional.");
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
                    string query = "SELECT * FROM ingrediente_adicional";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewIngredienteExtra.DataSource = table;
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
            txtIdIngrediente.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idIngrediente;
            if (!int.TryParse(txtIdIngrediente.Text, out idIngrediente))
            {
                MessageBox.Show("El ID del ingrediente debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            decimal costo;
            if (!decimal.TryParse(txtPrecio.Text, out costo))
            {
                MessageBox.Show("El costo del ingrediente debe ser un número decimal válido.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ingrediente_adicional SET nombre = @Nombre, costo = @Costo WHERE id = @IdIngrediente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Costo", costo);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingrediente adicional modificado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el ingrediente adicional. No se encontró el ingrediente con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idIngrediente;
            if (!int.TryParse(txtIdIngrediente.Text, out idIngrediente))
            {
                MessageBox.Show("El ID del ingrediente debe ser un número entero.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ingrediente_adicional WHERE id = @IdIngrediente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingrediente adicional eliminado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el ingrediente adicional. No se encontró el ingrediente con el ID proporcionado.");
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

        private void dataGridViewIngredienteExtra_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIngredienteExtra.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewIngredienteExtra.SelectedRows[0];
                txtIdIngrediente.Text = row.Cells["id"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtPrecio.Text = row.Cells["costo"].Value.ToString();
            }
        }

    }
}
