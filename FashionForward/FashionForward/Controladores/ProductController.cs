using FashionForward.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FashionForward.Controladores
{
    public class ProductController
    {
        public bool crearProducto(Product product) 
        {
            //Dar de alta en la base de datos el producto
            String query = "insert into dbo.products values" +
               "(@id, " +
               "@name, " +
               "@image, " +
               "@description, " +
               "@stock, " +
               "@price, " +
               "@color, " +
               "@size, " +
               "@category, " +
               "@isActive " +
               ");";


            SqlCommand cmd = new SqlCommand(query, DbController.connection);
            cmd.Parameters.AddWithValue("@id", product.id);
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@image", product.image);
            cmd.Parameters.AddWithValue("@description", product.description);
            cmd.Parameters.AddWithValue("@stock", product.stock);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@color", product.color);
            cmd.Parameters.AddWithValue("@size", product.size);
            cmd.Parameters.AddWithValue("@category", product.category);
            cmd.Parameters.AddWithValue("@isActive", product.isActive);


            try
            { 
                DbController.connection.Open();
                cmd.ExecuteNonQuery();
                DbController.connection.Close();
                return true;
            } 
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
                return false;
            }
        }

        public static bool deleteProduct(int productid) {
            string query = "update dbo.products set isActive = 0 where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DbController.connection);
            cmd.Parameters.AddWithValue("@id", productid);

            try
            {
                DbController.connection.Open();
                cmd.ExecuteNonQuery();
                DbController.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public bool EditarProducto(Product producto, int productId)
        {
            return true;
        }

        public static List<Product> getAll()
        {
            List<Product> list = new List<Product>();
            string query = "select * from dbo.products where isActive = 1;";

            SqlCommand cmd = new SqlCommand(query, DbController.connection);

            try
            {
                DbController.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Lee los datos de la columna que contiene el array de bytes
                    byte[] bytes = new byte[(reader.GetBytes(2, 0, null, 0, int.MaxValue))];
                    reader.GetBytes(2, 0, bytes, 0, bytes.Length);

                    Product product = new Product(reader.GetInt32(0), reader.GetString(1), bytes, 
                        reader.GetString(3), reader.GetInt32(4), reader.GetDecimal(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetBoolean(9));
                    list.Add(product); 
                    Trace.WriteLine("Prod encontrado, nombre: " + reader.GetString(1));

                }
                reader.Close();
                DbController.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }
    }
}
