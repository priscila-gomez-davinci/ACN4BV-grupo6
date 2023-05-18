using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    public class Category
    {

        public int id { get; set; }
        public string category { get; set; }
        public Category(int id, string category)
        {
            this.id = id;
            this.category = category;
        }
    }
}
