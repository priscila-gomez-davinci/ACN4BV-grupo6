using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Controladores
{
    internal class DbController
    {
        private static string connectionString = "";
        public static SqlConnection connection;



        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = "localhost";
            builder.InitialCatalog = "fashion-forward";
            builder.IntegratedSecurity = true;

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);

            Trace.WriteLine("Conexion a la DB: " + connection);

        }
    }
}
