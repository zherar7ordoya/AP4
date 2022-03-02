using System.Collections.Generic;

namespace Filtro
{
    public class FiltroClientes
    {
        public IEnumerable<Cliente> FiltrarPor(
                                IList<Cliente> clientes,
                                EspecificacionFiltroCliente filtro)
        {
            return filtro.Filtrar(clientes);
        }
    }
}
