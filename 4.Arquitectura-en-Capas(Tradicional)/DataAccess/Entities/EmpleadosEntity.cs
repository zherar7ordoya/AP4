using System;

namespace DataAccess.Entities
{
    internal class EmpleadosEntity
    {
        public int IdPK { get; set; }
        public string IdLegajo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
