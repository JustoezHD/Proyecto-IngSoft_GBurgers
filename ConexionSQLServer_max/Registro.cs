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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIS
{
    public partial class Registro : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
        "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";

        public Registro()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void txtBoxNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxContrasena_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxDireccionEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxCURPEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxTelefonoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreEmpleado = txtBoxNombreEmpleado.Text;
                string nombreUsuario = txtBoxNombreUsuario.Text;
                string contraUsuario = txtBoxContrasena.Text;
                string direccionEmpleado = txtBoxDireccionEmpleado.Text;
                string curpEmpleado = txtBoxCURPEmpleado.Text;
                int telefonoEmpleado = Int32.Parse(txtBoxTelefonoEmpleado.Text);

                string query = string.Format("INSERT INTO USUARIO (nombre_usuario, Contraseña, CURP_emp " +
                    "VALUES ('{0}', '{1}', '{2}')",
                    nombreUsuario, contraUsuario, curpEmpleado);

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar la consulta SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection.Close();
                    MessageBox.Show("Usuario: '" + nombreUsuario + "' agregado correctamente");
                }
                txtBoxNombreEmpleado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtBoxNombreEmpleado.Focus();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IniciarSesion p = new IniciarSesion();
            this.Hide();
            p.Show();
        }
    }
}
