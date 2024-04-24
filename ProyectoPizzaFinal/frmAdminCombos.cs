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
    public partial class frmAdminCombos : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";
        public frmAdminCombos()
        {
            InitializeComponent();
            cmbTamaño.Items.AddRange(new string[] { "chico", "mediano", "grande" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCombo;
            //VALIDA QUE EL ID SEA NUMERO ENTERO
            if (!int.TryParse(txtIdCombo.Text, out idCombo))
            {
                MessageBox.Show("El ID del combo debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            //VALIDA QUE EL PRECIO SEA NUMERO DECIMAL
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio del combo debe ser un número decimal válido.");
                return;
            }

            string tamaño = cmbTamaño.SelectedItem?.ToString(); // Obtener el tamaño seleccionado del ComboBox

            //VALIDA QUE NO QUEDEN CAMPOS EN BLANCO
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(txtIdCombo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(tamaño))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //METODO DE INSERTAR A LA BASE DE DATOS
                    string query = "INSERT INTO combo (idcombo, nombre, descripcion, precio, tamaño) " +
                                   "VALUES (@IdCombo, @Nombre, @Descripcion, @Precio, @Tamaño)";
                    //SE EJECUTA EL QUERY
                    SqlCommand command = new SqlCommand(query, connection);
                    //SE AGREGAN LOS VALORES
                    command.Parameters.AddWithValue("@IdCombo", idCombo);
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
                        MessageBox.Show("Combo agregado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el combo.");
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
                    string query = "SELECT * FROM combo";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCombos.DataSource = table;
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
            txtIdCombo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbTamaño.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idCombo;
            if (!int.TryParse(txtIdCombo.Text, out idCombo))
            {
                MessageBox.Show("El ID del combo debe ser un número entero.");
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio del combo debe ser un número decimal válido.");
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
                    string query = "UPDATE combo SET nombre = @Nombre, descripcion = @Descripcion, precio = @Precio, tamaño = @Tamaño WHERE idcombo = @IdCombo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdCombo", idCombo);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Tamaño", tamaño);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Combo modificado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el combo. No se encontró el combo con el ID proporcionado.");
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
            int idCombo;
            if (!int.TryParse(txtIdCombo.Text, out idCombo))
            {
                MessageBox.Show("El ID del combo debe ser un número entero.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM combo WHERE idcombo = @IdCombo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdCombo", idCombo);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Combo eliminado exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el combo. No se encontró el combo con el ID proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdministrador frmMenuAdmin = new frmMenuAdministrador();
            frmMenuAdmin.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

