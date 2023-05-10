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

namespace ConexionSQLServer.Pedido
{
    public partial class AutorizacionDePedido : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        string nombreusuario = "";
        int leftco = 40;
        int topco = 20;

        public AutorizacionDePedido(string nomus)
        {
            InitializeComponent();
            nombreusuario = nomus;
            labelUsuario.Text = nombreusuario;
        }

        private void AutorizacionDePedido_Load(object sender, EventArgs e)
        {
            try
            {
                string query = ("SELECT num_referencia, nombre_cliente, total, metodopago" +
                    " FROM PEDIDO WHERE pagado = 0 AND confirmado = 1");

                int Fila = 0;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    DataSet ds = new DataSet();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "PEDIDOS_A_CONFIRMAR");

                        foreach (DataRow row in ds.Tables["PEDIDOS_A_CONFIRMAR"].Rows)
                        {
                            int numref = (int)(row["num_referencia"]);
                            float preciototal = float.Parse(row["total"].ToString());

                            Label labelPro = new Label();
                            labelPro.Left = leftco;
                            labelPro.Top = topco;
                            labelPro.AutoSize = true;
                            labelPro.Text = "Pedido de " + row["nombre_cliente"].ToString();
                            labelPro.Font = new Font("Arial", 10, FontStyle.Bold);
                            panel1.Controls.Add(labelPro);

                            DataGridView dataGridView1 = new DataGridView();
                            dataGridView1.Left = leftco + 2;
                            dataGridView1.Top = topco + 30;
                            dataGridView1.Width = 430;
                            dataGridView1.Height = 72;
                            dataGridView1.Columns.Add("Cant", "Cantidad");
                            dataGridView1.Columns.Add("Producto", "Producto");
                            dataGridView1.Columns.Add("Precio_Individual", "Precio_Individual");
                            dataGridView1.Columns[0].Width = 30;
                            dataGridView1.Columns[1].Width = 300;
                            dataGridView1.Columns[2].Width = 80;
                            panel1.Controls.Add(dataGridView1);

                            Label labelpr1 = new Label();
                            labelpr1.Left = leftco + 208;
                            labelpr1.Top = topco + 105;
                            labelpr1.Text = "Precio: $";
                            panel1.Controls.Add(labelpr1);

                            Label labelprecio = new Label();
                            labelprecio.Left = leftco + 288;
                            labelprecio.Top = topco + 105;
                            labelprecio.AutoSize = true;
                            labelprecio.Text = preciototal.ToString();
                            panel1.Controls.Add(labelprecio);

                            Button botonAutorizar = new Button();
                            botonAutorizar.Left = leftco + 480;
                            botonAutorizar.Top = topco + 18;
                            botonAutorizar.Width = 242;
                            botonAutorizar.Height = 22;
                            botonAutorizar.Text = "Autorizar";
                            botonAutorizar.Font = new Font("Evil Dead", 8, FontStyle.Regular);
                            botonAutorizar.Cursor = Cursors.Hand;
                            botonAutorizar.BackColor = Color.Purple;
                            botonAutorizar.ForeColor = Color.White;
                            panel1.Controls.Add(botonAutorizar);

                            botonAutorizar.Click += (s, e2) =>
                            {
                                try
                                {
                                    /*if (row["metodopago"].ToString() == "Efectivo")
                                    {

                                    }*/
                                    string query3 = ("UPDATE PEDIDO SET pagado = 1 WHERE " +
                                    "num_referencia = "+numref);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }


                            };

                            Button botonCancelar = new Button();
                            botonCancelar.Left = leftco + 480;
                            botonCancelar.Top = topco + 46;
                            botonCancelar.Width = 242;
                            botonCancelar.Height = 22;
                            botonCancelar.Text = "Cancelar";
                            botonCancelar.Font = new Font("Evil Dead", 8, FontStyle.Regular);
                            botonCancelar.Cursor = Cursors.Hand;
                            botonCancelar.BackColor = Color.Purple;
                            botonCancelar.ForeColor = Color.White;
                            panel1.Controls.Add(botonCancelar);
                            botonCancelar.Click += (s, e2) =>
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show("¿Seguro que quiere cancelar este pedido? Perderá toda la informacion contenida en el",
                                    "Eliminar pedido", buttons);
                                if (result == DialogResult.Yes)
                                {
                                    string query3 = ("DELETE FROM PEDIDO WHERE num_referencia = " + numref);
                                    using (SqlConnection connection2 = new SqlConnection(cadena))
                                    {
                                        connection2.Open();
                                        using (SqlCommand command2 = new SqlCommand(query3, connection2))
                                        {
                                            int rowsAffected = command2.ExecuteNonQuery();

                                            // Mostrar el número de filas afectadas por la consulta SQL
                                            Console.WriteLine("Rows affected: " + rowsAffected);
                                        }
                                        connection2.Close();
                                    };
                                    MessageBox.Show("Pedido eliminado correctamente");
                                }
                            };

                            Button botonEditar = new Button();
                            botonEditar.Left = leftco + 480;
                            botonEditar.Top = topco + 74;
                            botonEditar.Width = 242;
                            botonEditar.Height = 22;
                            botonEditar.Text = "Editar";
                            botonEditar.Font = new Font("Evil Dead", 8, FontStyle.Regular);
                            botonEditar.Cursor = Cursors.Hand;
                            botonEditar.BackColor = Color.Purple;
                            botonEditar.ForeColor = Color.White;
                            panel1.Controls.Add(botonEditar);
                            botonEditar.Click += (s, e2) =>
                            {
                                Menu mn1 = new Menu(numref);
                                this.Hide();
                                mn1.ShowDialog();
                                this.Show();
                            };

                            string query2 = ("SELECT cantidad, nombre_pro, precio" +
                    " FROM PRODUCTOS_PEDIDOS LEFT JOIN PRODUCTOS ON " +
                    "PRODUCTOS_PEDIDOS.id_producto = PRODUCTOS.id_producto WHERE " +
                    "PRODUCTOS_PEDIDOS.num_referencia = " + numref);
                            using (SqlCommand command2 = new SqlCommand(query2, connection))
                            {
                                SqlDataAdapter data2 = new SqlDataAdapter(command2);
                                data2.Fill(ds, "PRODUCTOS");

                                foreach (DataRow row2 in ds.Tables["PRODUCTOS"].Rows)
                                {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[Fila].Cells[0].Value = row2["cantidad"].ToString();
                                    dataGridView1.Rows[Fila].Cells[1].Value = row2["nombre_pro"].ToString();
                                    dataGridView1.Rows[Fila].Cells[2].Value = row2["precio"].ToString();
                                    Fila++;
                                }
                            }
                            topco += 136;
                        };
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que quiere cerrar la sesión?",
                "Cerrar sesión", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
