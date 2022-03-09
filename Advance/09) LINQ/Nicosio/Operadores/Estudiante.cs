using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Estudiante
    {
        public Estudiante(int iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"\nID: {ID}" +
                $"\nNombre: {Nombre}");
        }
    }
}
