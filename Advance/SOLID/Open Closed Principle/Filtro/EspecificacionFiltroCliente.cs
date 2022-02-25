using System.Collections.Generic;

namespace Filtro
{
    /// <summary>
    /// The abstract modifier indicates an incomplete implementation.
    /// The abstract modifier can be used with classes, methods, properties,
    /// indexers, and events.
    /// Use the abstract modifier in a class declaration to indicate that a
    /// class is intended only to be a base class of other classes, not
    /// instantiated on its own.
    /// </summary>
    public abstract class EspecificacionFiltroCliente
    {
        public IEnumerable<Cliente> Filtrar(IList<Cliente> clientes)
        {
            return AplicarFiltro(clientes);
        }

        /// <summary>
        /// Public Abstract has the same idea like other Public Methods:
        /// If you have a Abstract Class, you will pass this arround.
        /// So if this method should get called from outside, it's public.
        /// If the method is just for communication between Child and Parent,
        /// protected is the way to go.
        /// Easy example, see the Main-Method as the user of the abstract
        /// class (ejemplo "Protegido").
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        protected abstract IEnumerable<Cliente> AplicarFiltro(IList<Cliente> clientes);
    }
}
