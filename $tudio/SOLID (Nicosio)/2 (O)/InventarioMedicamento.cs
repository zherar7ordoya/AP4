using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__O_
{
    class InventarioMedicamento : BaseInventario
    {
        public InventarioMedicamento(Producto producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
