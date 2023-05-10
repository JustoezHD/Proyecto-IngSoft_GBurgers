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

namespace ProyectoIS
{
    public partial class IniciarSesion : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
        "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro p = new Registro();
            this.Hide();
            p.Show();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtBoxNombreUsuario.Text;
                string contraUsuario = txtBoxContrasena.Text;

                string query = "SELECT COUNT(*) FROM usuarios WHERE nombreUsuario=@nombreUsuario AND contraseña=@contraseña";

                // establecer los valores de los parámetros de la consulta SQL
                SqlParameter[] parameters = {
                new SqlParameter("@nombreUsuario", nombreUsuario),
                new SqlParameter("@contraseña", contraUsuario)
                };

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddRange(parameters);
                    int count = (int)command.ExecuteScalar();
                    // verificar el resultado y mostrar un mensaje apropiado
                    if (count > 0)
                    {
                        Console.WriteLine("El usuario ya existe en la base de datos."); 
                        /*Main p = new Main();
                        this.Hide();
                        p.Show();*/ 
                    }
                    else
                    {
                        Console.WriteLine("El usuario no se encuentra en la base de datos.");
                    }
                   
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtBoxNombreUsuario.Focus();
            }
        }
    }
}
