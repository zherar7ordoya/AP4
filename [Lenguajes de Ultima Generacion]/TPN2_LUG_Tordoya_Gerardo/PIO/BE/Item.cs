using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Item : Entidad
    {
        public int ItemID { get; set; }
        public string CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string ProveedorID { get; set; }
    }
}
