using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__D_
{
    class Auditor
    {
        private Almacen almacen;

        public Auditor(Almacen almacen)
        {
            this.almacen = almacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;

            foreach(Producto producto in almacen.Inventario)
            {
                if (producto.Tipo == 0)
                {
                    Console.WriteLine(producto);
                    total += producto.Costo;
                }
            }
            return total;
        }
    }
}
