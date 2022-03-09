using System;

namespace DataAccess.Entities
{
    public class Empleados
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
