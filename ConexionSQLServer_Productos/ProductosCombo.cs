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
    public partial class ProductosCombo : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int leftco = 155;
        int topco = 50;

        public ProductosCombo()
        {
            InitializeComponent();
            /*ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            panel1.Controls.Add(vScrollBar1);*/
        }

        private void ProductosCombo_Load(object sender, EventArgs e)
        {
            try
            {
                string query = ("SELECT * FROM PRODUCTOS WHERE categoria NOT LIKE 'Combos'");

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();
                    DataSet ds = new DataSet();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "PRODUCTOS");

                        foreach (DataRow row in ds.Tables["PRODUCTOS"].Rows)
                        {
                            PictureBox pb = new PictureBox();
                            pb.Left = leftco - 140;
                            pb.Top = topco - 20;
                            String direccionImagen = row["imagen"].ToString();
                            Console.WriteLine(direccionImagen);
                            pb.Size = new Size(120, 72);
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                            if (direccionImagen != "null")
                                pb.Image = Image.FromFile(direccionImagen);
                            panel1.Controls.Add(pb);

                            Label lbl = new Label();
                            lbl.Left = leftco;
                            lbl.Top = topco;
                            lbl.AutoSize = true;
                            lbl.Text = "Categoria: " + row["categoria"].ToString();
                            panel1.Controls.Add(lbl);

                            Label lb2 = new Label();
                            lb2.Left = leftco;
                            lb2.Top = topco + 20;
                            lb2.AutoSize = true;
                            lb2.Text = row["nombre_pro"].ToString();
                            lb2.Font = new Font("Arial", 12, FontStyle.Bold);
                            panel1.Controls.Add(lb2);

                            Label lbpesos = new Label();
                            lbpesos.Left = leftco + 200;
                            lbpesos.Top = topco;
                            lbpesos.AutoSize = true;
                            lbpesos.Text = "$" + row["precio"].ToString();
                            panel1.Controls.Add(lbpesos);

                            CheckBox cb1 = new CheckBox();
                            cb1.Left = leftco + 345;
                            cb1.Top = topco;
                            cb1.Checked = false;
                            panel1.Controls.Add(cb1);

                            NumericUpDown nud1 = new NumericUpDown();
                            nud1.Left = leftco + 470;
                            nud1.Size = new Size(66, 22);
                            nud1.Top = topco;
                            nud1.Value = 1;
                            nud1.Maximum = 10;
                            nud1.Minimum = 1;
                            panel1.Controls.Add(nud1);

                            topco += 100;
                        }
                        // Ejecutar la consulta SQL
                        //int rowsAffected = command.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        //Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection.Close();
                    //MessageBox.Show("Registro agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
