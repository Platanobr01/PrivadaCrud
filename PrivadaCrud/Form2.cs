using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PrivadaCrud.Config;

namespace PrivadaCrud
{   
    public partial class Form2 : Form
    {
        private SqlConnection conexion = Conexion.Conectar();

        private void InitializeComponent()
        {
            this.dt = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadeAlta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RazonSocial = new System.Windows.Forms.TextBox();
            this.Trabajo = new System.Windows.Forms.TextBox();
            this.FechaAlta = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(12, 140);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(340, 150);
            this.dt.TabIndex = 0;
            this.dt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellContentClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Razon Social";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trabajo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FechadeAlta
            // 
            this.FechadeAlta.AutoSize = true;
            this.FechadeAlta.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadeAlta.Location = new System.Drawing.Point(8, 58);
            this.FechadeAlta.Name = "FechadeAlta";
            this.FechadeAlta.Size = new System.Drawing.Size(124, 16);
            this.FechadeAlta.TabIndex = 4;
            this.FechadeAlta.Text = "Fecha de alta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del Trabajador";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(129, 23);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(100, 20);
            this.RazonSocial.TabIndex = 18;
            // 
            // Trabajo
            // 
            this.Trabajo.Location = new System.Drawing.Point(88, 92);
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Size = new System.Drawing.Size(100, 20);
            this.Trabajo.TabIndex = 17;
            // 
            // FechaAlta
            // 
            this.FechaAlta.Location = new System.Drawing.Point(138, 60);
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Size = new System.Drawing.Size(100, 20);
            this.FechaAlta.TabIndex = 10;
            this.FechaAlta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(427, 13);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 16;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(32, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 33);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(161, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(463, 283);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(160, 46);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.FechaAlta);
            this.Controls.Add(this.Trabajo);
            this.Controls.Add(this.RazonSocial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechadeAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dt);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Form2()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void dt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void textBox4_TextChanged(object sender, EventArgs e)
        { }

        private void textBox5_TextChanged(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void label5_Click(object sender, EventArgs e)
        { }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            DataTable datatable = new DataTable();
            string sql = "SELECT * FROM dbo.Proveedores";

            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatable);

            dt.DataSource = datatable;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string Sql_Insert = "INSERT INTO dbo.Proveedores(RazonSocial, FechaAlta, Trabajo, Nombre) VALUES (@RazonSocial, @FechaAlta, @Trabajo, @Nombre);";

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                using (SqlCommand command1 = new SqlCommand(Sql_Insert, conexion))
            {
                    command1.Parameters.AddWithValue("@RazonSocial", RazonSocial.Text);
                    command1.Parameters.AddWithValue("@FechaAlta", FechaAlta.Text);
                    command1.Parameters.AddWithValue("@Trabajo", Trabajo.Text);
                    command1.Parameters.AddWithValue("@Nombre", Nombre.Text);

                try
                {
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en guardar: " + ex.Message);
                }
                finally
                {
                    if(conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }

            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dt.SelectedRows.Count > 0)
            {
                string idTrabajo = dt.SelectedRows[0].Cells["RazonSocial"].Value.ToString();

                string SQL_Delete = "DELETE FROM dbo.Proveedores WHERE RazonSocial = @RazonSocial";

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                using (SqlCommand comando = new SqlCommand(SQL_Delete, conexion))
                {
                    comando.Parameters.AddWithValue("@RazonSocial", idTrabajo);

                    try
                    {
                        int filasAfectadas = comando.ExecuteNonQuery();
                        MessageBox.Show($"Se elimino exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
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
                MessageBox.Show("Seleccione una fila para borrar.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dt.SelectedRows.Count > 0)
            {
                dt.ReadOnly = false;
                dt.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Seleccione fila para editar.");
            }
        }
    }
}