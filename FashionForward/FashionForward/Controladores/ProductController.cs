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
            String query = "insert into dbo.product values" +
               "(@id, " +
               "(@name, " +
               "(@image, " +
               "(@description, " +
               "(@stock, " +
               "(@price, " +
               "(@color, " +
               "(@size, " +
               "(@categories, " +
               "(@isActive, " +
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
            cmd.Parameters.AddWithValue("@categories", product.categories);
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

        public bool EliminarProducto(string productid) {
            return true;
        }

        public bool EditarProducto(Product producto, int productId)
        {
            return true;
        }

        public List<Product> ObtenerTodos()
        {
            List<Product> list = new List<Product>();   
            return list;
        }
    }
}
