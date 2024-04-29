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
    public partial class frmAdminPromociones : Form
    {
        //SE ESTABLECE LA CONEXIÓN CON LA BASE DE DATOS DE LA PIZZERIA
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=pizzeria;Integrated Security=True";
        public frmAdminPromociones()
        {
            InitializeComponent();
            ActualizarDataGridView();
            dataGridViewPromociones.SelectionChanged += dataGridViewPromociones_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPromocion;
            // VALIDA QUE EL ID SEA NUMERO ENTERO
            if (!int.TryParse(txtIdPromocion.Text, out idPromocion))
            {
                MessageBox.Show("El ID de la promoción debe ser un número entero.");
                return;
            }

            string descripcion = txtDescripcion.Text;
            string codigo = txtCodigo.Text;
            int cantidad;
            // VALIDA QUE LA CANTIDAD SEA NUMERO ENTERO
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad de la promoción debe ser un número entero.");
                return;
            }

            DateTime fechaInicio = dtFechaInicio.Value.Date;
            DateTime fechaFin = dtFechaFin.Value.Date;

            // VALIDA QUE NO QUEDEN CAMPOS EN BLANCO
            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // METODO DE INSERTAR A LA BASE DE DATOS
                    string query = "INSERT INTO promociones (idpromocion, descripcion, codigo, cantidad, fecha_inicio, fecha_fin) " +
                                   "VALUES (@IdPromocion, @Descripcion, @Codigo, @Cantidad, @FechaInicio, @FechaFin)";
                    // SE EJECUTA EL QUERY
                    SqlCommand command = new SqlCommand(query, connection);
                    // SE AGREGAN LOS VALORES
                    command.Parameters.AddWithValue("@IdPromocion", idPromocion);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    // SE ABRE LA CONEXION
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    // VALIDA SI SE AGREGARON LOS DATOS O NO
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Promoción agregada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la promoción.");
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
                    string query = "SELECT * FROM promociones";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewPromociones.DataSource = table;
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
            txtIdPromocion.Text = "";
            txtDescripcion.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            dtFechaInicio.Value = DateTime.Today; // Restablecer la fecha de inicio a la fecha actual
            dtFechaFin.Value = DateTime.Today; // Restablecer la fecha de fin a la fecha actual
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idPromocion;
            if (!int.TryParse(txtIdPromocion.Text, out idPromocion))
            {
                MessageBox.Show("El ID de la promoción debe ser un número entero.");
                return;
            }

            string descripcion = txtDescripcion.Text;
            string codigo = txtCodigo.Text;
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad de la promoción debe ser un número entero.");
                return;
            }

            DateTime fechaInicio = dtFechaInicio.Value.Date;
            DateTime fechaFin = dtFechaFin.Value.Date;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE promociones SET descripcion = @Descripcion, codigo = @Codigo, cantidad = @Cantidad, fecha_inicio = @FechaInicio, fecha_fin = @FechaFin WHERE idpromocion = @IdPromocion";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPromocion", idPromocion);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Promoción modificada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView(); // Asegúrate de que este método esté implementado para actualizar la tabla en tu formulario
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la promoción. No se encontró la promoción con el ID proporcionado.");
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
            int idPromocion;
            if (!int.TryParse(txtIdPromocion.Text, out idPromocion))
            {
                MessageBox.Show("El ID de la promoción debe ser un número entero.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM promociones WHERE idpromocion = @IdPromocion";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPromocion", idPromocion);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Promoción eliminada exitosamente.");
                        LimpiarCampos();
                        ActualizarDataGridView(); // Asegúrate de que este método esté implementado para actualizar la tabla en tu formulario
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la promoción. No se encontró la promoción con el ID proporcionado.");
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

        private void dataGridViewPromociones_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPromociones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPromociones.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                int idPromocion = Convert.ToInt32(selectedRow.Cells["idpromocion"].Value);
                string descripcion = Convert.ToString(selectedRow.Cells["descripcion"].Value);
                string codigo = Convert.ToString(selectedRow.Cells["codigo"].Value);
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                DateTime fechaInicio = Convert.ToDateTime(selectedRow.Cells["fecha_inicio"].Value);
                DateTime fechaFin = Convert.ToDateTime(selectedRow.Cells["fecha_fin"].Value);

                // Mostrar los valores en los controles de tu formulario
                txtIdPromocion.Text = idPromocion.ToString();
                txtDescripcion.Text = descripcion;
                txtCodigo.Text = codigo;
                txtCantidad.Text = cantidad.ToString();
                dtFechaInicio.Value = fechaInicio;
                dtFechaFin.Value = fechaFin;
            }
            else
            {
                // Limpiar los controles si no hay ninguna fila seleccionada
                LimpiarCampos();
            }
        }

    }
}

