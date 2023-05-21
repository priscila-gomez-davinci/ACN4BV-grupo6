using FashionForward.Controladores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionForward
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DbController.initialize();

            if (validateConnection())
            {
                Trace.WriteLine("Conexion a la base de datos establecida con exito");
            }

            Application.Run(new AuthenticationForm()); // new Form1()

            // Application.Run(new Form1());
        }
        public static bool validateConnection()
        {
            try
            {
                DbController.connection.Open();
                DbController.connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}
