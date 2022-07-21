using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__O_
{
    class InventarioAlimento : BaseInventario
    {
        public InventarioAlimento(Producto producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
