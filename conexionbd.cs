using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConexionSQLServer
{
    class conexionbd
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";

        public SqlConnection Conectarbd = new SqlConnection();

        public conexionbd()
        {
            Conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " +ex.Message);
            }
        }

        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
