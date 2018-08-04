using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.business;
using upc.order.entities;

namespace upc.order.viewconsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVenta VentaB = new VentaB();
            Venta ObjV = new Venta()
            {
                Producto="Producto 1",
                Cantidad=1
            };

            VentaB.Create(ObjV);

            Console.ReadKey();
        }
    }
}
