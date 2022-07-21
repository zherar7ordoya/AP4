using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__D_
{
    class Almacen
    {
        private List<Producto> inventario;

        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public Almacen()
        { 
            inventario= new List<Producto>();
        }

        public void AdicionarProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine("Adicionamos {0}", producto.Nombre);
        }

    }
}
