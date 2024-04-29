using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoPizzaFinal
{
    public partial class frmAdminPizzas : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";
        public frmAdminPizzas()
        {
            InitializeComponent();
            cmbTamaño.Items.AddRange(new string[] { "individual", "mediana", "grande", "familiar" });
            ActualizarDataGridView();
            dataGridViewPizzas.SelectionChanged += dataGridViewPizzas_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idPizza;
            //VALIDA QUE EL ID SEA NUMERO ENTERO
            if (!int.TryParse(txtIdPizza.Text, out idPizza))
            {
                MessageBox.Show("El ID de la pizza debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            //VALIDA QUE EL PRECIO SEA NUMERO DECIMAL
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio de la pizza debe ser un número decimal válido.");
                return;
            }

            string tamaño = cmbTamaño.SelectedItem?.ToString(); // Obtener el tamaño seleccionado del ComboBox

            //VALIDA QUE NO QUEDEN CAMPOS EN BLANCO
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(txtIdPizza.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(tamaño))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //METODO DE INSERTAR A LA BASE DE DATOS
                    string query = "INSERT INTO pizzas (idpizza, nombre, descripcion, precio, tamaño) " +
                                   "VALUES (@IdPizza, @Nombre, @Descripcion, @Precio, @Tamaño)";
                    //SE EJECUTA EL QUERY
                    SqlCommand command = new SqlCommand(query, connection);
                    //SE AGREGAN LOS VALORES
                    command.Parameters.AddWithValue("@IdPizza", idPizza);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Tamaño", tamaño);
                    //SE ABRE LA CONEXION
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    //VALIDA SI SE AGREGARON LOS DATOS O NO
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pizza agregada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la pizza.");
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
                    string query = "SELECT * FROM pizzas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewPizzas.DataSource = table;
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
            txtIdPizza.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbTamaño.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idPizza;
            if (!int.TryParse(txtIdPizza.Text, out idPizza))
            {
                MessageBox.Show("El ID de la pizza debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio de la pizza debe ser un número decimal válido.");
                return;
            }

            string tamaño = cmbTamaño.SelectedItem?.ToString(); // Obtener el tamaño seleccionado del ComboBox

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(tamaño))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE pizzas SET nombre = @Nombre, descripcion = @Descripcion, precio = @Precio, tamaño = @Tamaño WHERE idpizza = @IdPizza";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPizza", idPizza);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Tamaño", tamaño);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pizza modificada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la pizza. No se encontró la pizza con el ID proporcionado.");
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
            int idPizza;
            if (!int.TryParse(txtIdPizza.Text, out idPizza))
            {
                MessageBox.Show("El ID de la pizza debe ser un número entero.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM pizzas WHERE idpizza = @IdPizza";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPizza", idPizza);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pizza eliminada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la pizza. No se encontró la pizza con el ID proporcionado.");
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

        private void dataGridViewPizzas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPizzas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPizzas.SelectedRows[0];
                txtIdPizza.Text = row.Cells["idpizza"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["precio"].Value.ToString();
                cmbTamaño.SelectedItem = row.Cells["tamaño"].Value.ToString();
            }
        }

    }
}
    

