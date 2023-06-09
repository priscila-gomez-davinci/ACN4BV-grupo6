﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    public class Product
    {
        public Product(int id, string name, 
            string image,string descripcion, int stock, 
            double price, string color, Sizes size, 
            CategoriesList categories, Boolean isActive ) 
        { 
            this.id = id;
            this.name = name;
            this.image = image;
            this.description = descripcion;
            this.stock = stock;
            this.price = price;
            this.color = color;
            this.size = size;
            this.categories = categories;
            this.isActive = isActive;

        }
        public Product()
        { 

        }

        public enum Sizes
        {
            XS,
            S,
            M,
            L,
            XL,
            XXL,
            XXXL
        }

        public enum CategoriesList
        {
            casual,
            elegant,
            formal,
            office
        }

        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public double price { get; set; }
        public string color { get; set; }
        public Sizes size { get; set; }
        public CategoriesList categories { get; set; }
        public List<CategoriesList> Categorias { get; set; }
        public Boolean isActive { get; set; }


    }
}
