using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PrivadaCrud.Config;

namespace PrivadaCrud
{   
    public partial class Form2 : Form
    {
        private void InitializeComponent()
        {
            this.dt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Trabajo = new System.Windows.Forms.TextBox();
            this.Empresa = new System.Windows.Forms.TextBox();
            this.Llegada = new System.Windows.Forms.TextBox();
            this.Acompañante = new System.Windows.Forms.TextBox();
            this.NombreA = new System.Windows.Forms.TextBox();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
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
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de llegada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Acompañantes\r\n(En caso de no, omitir)\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre de \r\nlos Acompañantes";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(99, 9);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 7;
            // 
            // Trabajo
            // 
            this.Trabajo.Location = new System.Drawing.Point(99, 53);
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Size = new System.Drawing.Size(100, 20);
            this.Trabajo.TabIndex = 8;
            // 
            // Empresa
            // 
            this.Empresa.Location = new System.Drawing.Point(99, 92);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(100, 20);
            this.Empresa.TabIndex = 9;
            // 
            // Llegada
            // 
            this.Llegada.Location = new System.Drawing.Point(244, 29);
            this.Llegada.Name = "Llegada";
            this.Llegada.Size = new System.Drawing.Size(100, 20);
            this.Llegada.TabIndex = 10;
            this.Llegada.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Acompañante
            // 
            this.Acompañante.Location = new System.Drawing.Point(487, 55);
            this.Acompañante.Name = "Acompañante";
            this.Acompañante.Size = new System.Drawing.Size(100, 20);
            this.Acompañante.TabIndex = 11;
            this.Acompañante.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // NombreA
            // 
            this.NombreA.Location = new System.Drawing.Point(487, 130);
            this.NombreA.Name = "NombreA";
            this.NombreA.Size = new System.Drawing.Size(116, 20);
            this.NombreA.TabIndex = 12;
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
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.NombreA);
            this.Controls.Add(this.Acompañante);
            this.Controls.Add(this.Llegada);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.Trabajo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { }

        private void textBox5_TextChanged(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
    }
}