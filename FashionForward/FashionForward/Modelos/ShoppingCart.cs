using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Modelos
{
    internal class ShoppingCart
    {

        private static ShoppingCart instancia;

        private ShoppingCart()
        {

        }

        public static ShoppingCart GetCart()
        {
            if (instancia == null)
            {
                instancia = new ShoppingCart();
            }
            return instancia;
        }

        public void EliminarProducto(Product product)
        {
            Console.WriteLine($"El producto {product} ha sido eliminado de la base de datos");
        }

        public void AgregarProducto(Product product)
        {
            Console.WriteLine($"El producto {product} ha sido agregado a la base de datos");
        }

    }
}
