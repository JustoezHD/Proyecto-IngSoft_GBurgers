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

namespace ConexionSQLServer.Menus
{
    public partial class MenuABC : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
           "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        string tabla = "";
        public MenuABC(string tablaabuscar)
        {
            InitializeComponent();
            tabla = tablaabuscar;
            label1.Text = tabla;
            if(tabla== "COMBO_PRODUCTOS")
            {
                buttonAlta.Enabled = false;
                buttonBaja.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabla=="PRODUCTOS")
            {
                AltaProducto alta1 = new AltaProducto();
                this.Hide();
                alta1.ShowDialog();
                this.Show();
            }
            
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabla == "COMBO_PRODUCTOS")
            {
                ProductosCombo alta1 = new ProductosCombo();
                this.Hide();
                alta1.ShowDialog();
                this.Show();
            }
        }

        private void MenuABC_Load(object sender, EventArgs e)
        {
            string query = "";
            if (tabla=="PRODUCTOS"|| tabla == "PEDIDO")
            {
                query = ("SELECT * FROM " + tabla);
            }
            else
            {
                if(tabla== "COMBO_PRODUCTOS")
                {
                    query = ("SELECT * FROM " + tabla);
                }
                else if(tabla=="PRODUCTOS_PEDIDOS")
                {
                    query = ("SELECT * FROM PEDIDO RIGHT JOIN PRODUCTOS_PEDIDOS ON " +
                        "PEDIDO.num_referencia = PRODUCTOS_PEDIDOS.num_referencia");
                }
            }

            try {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    DataSet ds = new DataSet();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "DATOSTABLA");
                        if (tabla == "PRODUCTOS")
                        {
                            dataGridView1.Columns.Add("ID", "ID");
                            dataGridView1.Columns.Add("Producto", "Producto");
                            dataGridView1.Columns.Add("Descripcion", "Descripcion");
                            dataGridView1.Columns.Add("Precio", "Precio");
                            dataGridView1.Columns.Add("Categoria", "Categoria");
                            dataGridView1.Columns[0].Width = 20;
                            dataGridView1.Columns[1].Width = 236;
                            dataGridView1.Columns[2].Width = 300;
                            dataGridView1.Columns[3].Width = 60;
                            dataGridView1.Columns[4].Width = 80;
                        }
                        if (tabla == "PEDIDO")
                        {
                            dataGridView1.Columns.Add("ID", "ID");
                            dataGridView1.Columns.Add("Cliente", "Cliente");
                            dataGridView1.Columns.Add("Fecha", "Fecha");
                            dataGridView1.Columns.Add("Total", "Total");
                            dataGridView1.Columns.Add("Metodo_Pago", "Metodo_Pago");
                            dataGridView1.Columns.Add("Confirmado", "Confirmado");
                            dataGridView1.Columns.Add("Pagado", "Pagado");
                            dataGridView1.Columns[0].Width = 18;
                            dataGridView1.Columns[1].Width = 100;
                            dataGridView1.Columns[2].Width = 150;
                            dataGridView1.Columns[3].Width = 60;
                            dataGridView1.Columns[4].Width = 80;
                            dataGridView1.Columns[5].Width = 40;
                            dataGridView1.Columns[6].Width = 40;
                        }

                        int Fila = 0;
                        foreach (DataRow row in ds.Tables["DATOSTABLA"].Rows)
                        {
                            if (tabla == "PRODUCTOS")
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[Fila].Cells[0].Value = row["id_producto"].ToString();
                                dataGridView1.Rows[Fila].Cells[1].Value = row["nombre_pro"].ToString();
                                dataGridView1.Rows[Fila].Cells[2].Value = row["descripcion"].ToString();
                                dataGridView1.Rows[Fila].Cells[3].Value = row["precio"].ToString();
                                dataGridView1.Rows[Fila].Cells[4].Value = row["categoria"].ToString();
                            }
                            if (tabla == "PEDIDO")
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[Fila].Cells[0].Value = row["num_referencia"].ToString();
                                dataGridView1.Rows[Fila].Cells[1].Value = row["nombre_cliente"].ToString();
                                dataGridView1.Rows[Fila].Cells[2].Value = row["fecha"].ToString();
                                dataGridView1.Rows[Fila].Cells[3].Value = row["total"].ToString();
                                dataGridView1.Rows[Fila].Cells[4].Value = row["metodopago"].ToString();
                                dataGridView1.Rows[Fila].Cells[5].Value = row["confirmado"].ToString();
                                dataGridView1.Rows[Fila].Cells[6].Value = row["pagado"].ToString();
                            }
                            Fila++;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
