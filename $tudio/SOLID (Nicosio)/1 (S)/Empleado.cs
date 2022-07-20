using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__S_
{
    class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Empleado
        (
            string nombre,
            string puesto,
            int edad,
            double sueldo
        )
        {
            this.Nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            this.Sueldo = sueldo;
        }

        public override string ToString()
        {
            return string.Format
            (
                "{0}, {1}, {2}, {3}",
                Nombre, puesto, edad, Sueldo
            );
        }

        
    }
}
