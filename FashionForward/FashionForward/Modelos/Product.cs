using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    public class Product
    {
        public Product(int id, string name,
            byte[] image, string descripcion, int stock,
            decimal price, string color, string size,
            string category, Boolean isActive)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.description = descripcion;
            this.stock = stock;
            this.price = price;
            this.color = color;
            this.size = size;
            this.category = category;
            this.isActive = isActive;

        }

        public Product(int id)
        {
            this.id = id;
        }
        public Product()
        {

        }

        public int id { get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public decimal price { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public string category { get; set; }
        public Boolean isActive { get; set; }


    }
}
