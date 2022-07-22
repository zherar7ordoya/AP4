using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__D_
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenerProductos(int tipo);
    }
}
