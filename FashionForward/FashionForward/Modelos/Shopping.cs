using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    internal class Shopping
    {

        public enum StatusList
        {
            SUCCESS,
            PENDING,
            CANCELLED
        }
        private int id { get; set; }
        private DateTime date { get; set; }
        private Double total { get; set; }
        private List<Product> products { get; set; }
        private StatusList status { get; set; }
        private int stock { get; set; }
    }
}
