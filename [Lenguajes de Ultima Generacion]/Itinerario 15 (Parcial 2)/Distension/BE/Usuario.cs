using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario : Entidad
    {
        public Usuario()
        {
        }

        public Usuario(Ingreso autenticacion, List<Puntaje> puntajes)
        {
            Autenticacion = autenticacion;
            Puntajes = puntajes;
        }

        public Usuario
        (
            int codigo,
            string nombre,
            string apellido,
            int dNI,
            string email,
            DateTime fechaNacimiento,
            string localidadResidencia
        )
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            LocalidadResidencia = localidadResidencia;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LocalidadResidencia { get; set; }
        public Ingreso Autenticacion { get; set; }
        public List<Puntaje> Puntajes { get; set; }
    }
}
