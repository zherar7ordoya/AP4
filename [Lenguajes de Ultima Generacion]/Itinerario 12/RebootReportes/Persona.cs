using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebootReportes
{
    class Persona
    {
        public Persona(int cod, string nombre, string apellido, int dni, string correo, DateTime nacimiento)
        {
            Cod = cod;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            DNI = dni;
            Correo = correo ?? throw new ArgumentNullException(nameof(correo));
            FechaNac = nacimiento;
        }

        public int      Cod      { get; set; }
        public string   Nombre   { get; set; }
        public string   Apellido { get; set; }
        public int      DNI      { get; set; }
        public string   Correo   { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
