using System.Collections.Generic;
using System.Linq;

namespace Filtro
{
    public class FiltroLocalidad : EspecificacionFiltroCliente
    {
        private Localidades localidad;

        public FiltroLocalidad(Localidades localidad)
        {
            this.localidad = localidad;
        }

        protected override IEnumerable<Cliente> AplicarFiltro(IList<Cliente> clientes)
        {
            return clientes.Where(c => c.Localidad == this.localidad);
        }
    }
}
