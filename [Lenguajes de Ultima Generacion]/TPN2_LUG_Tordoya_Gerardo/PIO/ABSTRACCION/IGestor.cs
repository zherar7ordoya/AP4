using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACCION
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Eliminar(T objeto);
        T ListarObjeto(T objeto);
        List<T> ListarTodo();
    }
}
