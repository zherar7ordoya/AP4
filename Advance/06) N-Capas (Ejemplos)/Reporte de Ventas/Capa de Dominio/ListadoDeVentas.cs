using System;

namespace Capa_de_Dominio
{
    public class ListadoDeVentas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public double Total { get; set; }
    }
}
