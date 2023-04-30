using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Controladores
{
    internal class DbController
    {
        private static string connectionString = "";
        public static SqlConnection connection;

        public static String integrante = "Priscila";

        public static void inicialize()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "fashion-forward";
            builder.IntegratedSecurity = true;


            //"Data Source = localhost; Initial Catalog=dbSystemABM; Integrated Security= True"
            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }
}
