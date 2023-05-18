using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    public class Size
    {
        public int id { get; set; }
        public string size { get; set; }
        public Size(int id, string size)
        {
            this.id = id;
            this.size = size;
        }
    }
}
