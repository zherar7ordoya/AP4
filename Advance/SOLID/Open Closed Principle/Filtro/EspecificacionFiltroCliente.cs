using System.Collections.Generic;

namespace Filtro
{
    public abstract class EspecificacionFiltroCliente
    {
        public IEnumerable<Cliente> Filtrar(IList<Cliente> clientes)
        {
            return AplicarFiltro(clientes);
        }

        protected abstract IEnumerable<Cliente> AplicarFiltro(IList<Cliente> clientes);
    }
}
