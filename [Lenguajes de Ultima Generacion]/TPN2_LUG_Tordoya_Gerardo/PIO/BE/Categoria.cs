using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria : ENTIDAD
    {
        public string CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}
