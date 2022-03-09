using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Desktop.ViewModels
{
    internal class ClientesViewModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
    }
}
