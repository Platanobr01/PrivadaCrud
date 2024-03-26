using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PrivadaCrud.Config;

namespace PrivadaCrud
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = Conexion.Conectar();
        private bool tieneMascotasSeleccionado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { }

        public void CargarDatos()
        {
            DataTable datatable = new DataTable();
            string sql = "SELECT * FROM dbo.Residentes";

            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatable);

            dt.DataSource = datatable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica si se seleccionó una fila para editar
            if (dt.SelectedRows.Count > 0)
            {
                dt.ReadOnly = false; // Habilita la edición en el DataGridView
                dt.BeginEdit(true); // Inicia la edición de la celda seleccionada
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para editar.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dt.SelectedRows.Count > 0)
            {
                string idResidente = dt.SelectedRows[0].Cells["Nombre"].Value.ToString();

                string SQL_Delete = "DELETE FROM dbo.Residentes WHERE Nombre = @Nombre";

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                using (SqlCommand comando = new SqlCommand(SQL_Delete, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", idResidente);

                    try
                    {
                        int filasAfectadas = comando.ExecuteNonQuery();
                        MessageBox.Show($"Se elimino el residente '{idResidente}'.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al borrar al residente: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una fila para borrar.");
            }
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            string SQL_Insert = "INSERT INTO dbo.Residentes(Nombre, ApellidoPaterno, TipoResidente, ApellidoMaterno, Correo, Telefono, NumCasa, FechaAlta) VALUES (@Nombre, @ApellidoPaterno, @TipoResidente, @ApellidoMaterno, @Correo, @Telefono, @NumCasa, @FechaAlta)";

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            using (SqlCommand command1 = new SqlCommand(SQL_Insert, conexion))
            {
                command1.Parameters.AddWithValue("@Nombre", textBox1.Text);
                command1.Parameters.AddWithValue("@ApellidoPaterno", textBox2.Text);
                command1.Parameters.AddWithValue("@ApellidoMaterno", textBox8.Text);
                command1.Parameters.AddWithValue("@TipoResidente", checkedListBox1.Text);
                command1.Parameters.AddWithValue("@Telefono", textBox3.Text);
                command1.Parameters.AddWithValue("@Correo", textBox5.Text);
                command1.Parameters.AddWithValue("@NumCasa", textBox6.Text);
                command1.Parameters.AddWithValue("@FechaAlta", DateTime.Now); // Puedes utilizar la fecha actual

                try
                {
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Datos Ingresados en tabla de Residentes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar los datos: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }

            CargarDatos(); // Actualizar la tabla después de la inserción

            // Verifica si la opción "Tiene Mascotas" está seleccionada y se añaden los datos solo si está seleccionada.
            if (tieneMascotasSeleccionado)
            {
                GuardarDatosEnTablaResidentesMascotas();
            }
        }

        private void dt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            // Permitir que solo un elemento esté marcado a la vez
            foreach (int index in checkedListBox.CheckedIndices)
            {
                if (index != e.Index)
                {
                    checkedListBox.SetItemChecked(index, false);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si la opción "Tiene Mascotas" está seleccionada
            tieneMascotasSeleccionado = checkedListBox2.GetItemChecked(0);
        }

        private void GuardarDatosEnTablaResidentesMascotas()
        {
            string SQL_Insert = "INSERT INTO dbo.ResidentesMascotas(Nombre, ApellidoPaterno, TipoResidente, ApellidoMaterno, Correo, Telefono, NumCasa, FechaAlta) VALUES (@Nombre, @ApellidoPaterno, @TipoResidente, @ApellidoMaterno, @Correo, @Telefono, @NumCasa, @FechaAlta)";

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            using (SqlCommand command1 = new SqlCommand(SQL_Insert, conexion))
            {
                command1.Parameters.AddWithValue("@Nombre", textBox1.Text);
                command1.Parameters.AddWithValue("@ApellidoPaterno", textBox2.Text);
                command1.Parameters.AddWithValue("@ApellidoMaterno", textBox8.Text);
                command1.Parameters.AddWithValue("@TipoResidente", checkedListBox1.Text);
                command1.Parameters.AddWithValue("@Telefono", textBox3.Text);
                command1.Parameters.AddWithValue("@Correo", textBox5.Text);
                command1.Parameters.AddWithValue("@NumCasa", textBox6.Text);
                command1.Parameters.AddWithValue("@FechaAlta", DateTime.Now); // Puedes utilizar la fecha actual

                try
                {
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Datos Ingresados en tabla de Residentes con Mascotas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar los datos: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }

            CargarDatos(); // Actualizar la tabla después de la inserción
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Form2
            Form2 form2 = new Form2();

            // Mostrar el Form2
            form2.Show();
        }
    }
}
