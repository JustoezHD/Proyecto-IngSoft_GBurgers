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

namespace ConexionSQLServer
{

    public partial class Menu : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int idpedido=0;
        public Menu(int numpedido)
        {
            InitializeComponent();
            idpedido = numpedido;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuOtros mo1 = new MenuOtros(idpedido, "Hamburguesas");
            this.Hide();
            mo1.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuOtros mo1 = new MenuOtros(idpedido, "Combos");
            this.Hide();
            mo1.ShowDialog();
            this.Show();
        }

        private void pictureBoxCarrito_Click(object sender, EventArgs e)
        {
            Carrito cr1 = new Carrito(idpedido);
            this.Hide();
            cr1.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuOtros mo1 = new MenuOtros(idpedido,"Otros");
            this.Hide();
            mo1.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuOtros mo1 = new MenuOtros(idpedido, "Bebidas");
            this.Hide();
            mo1.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MenuOtros mo1 = new MenuOtros(idpedido, "Combos");
            this.Hide();
            mo1.ShowDialog();
            this.Show();
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que quiere cancelar este pedido? Perderá toda la informacion contenida en el",
                "Eliminar pedido", buttons);
            if (result == DialogResult.Yes)
            {
                string query2 = ("DELETE FROM PEDIDO WHERE num_referencia = " + idpedido);
                using (SqlConnection connection2 = new SqlConnection(cadena))
                {
                    connection2.Open();
                    using (SqlCommand command2 = new SqlCommand(query2, connection2))
                    {
                        int rowsAffected = command2.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection2.Close();
                };
                this.Close();
            }
        }
    }
}
