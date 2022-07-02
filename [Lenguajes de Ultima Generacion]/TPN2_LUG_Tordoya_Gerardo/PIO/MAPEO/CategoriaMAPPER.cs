using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPEO
{
    public class CategoriaMAPPER : ABSTRACCION.IGestor<BE.Categoria_BE>
    {
        // *----------------------------------------------=> VARIABLES DE CLASE
        
        readonly DA.Conexion conexion;
        Hashtable htabla;

        // *---------------------------------------------------=> CONSTRUCTORES

        public CategoriaMAPPER() => conexion = new DA.Conexion();

        // *---------------------------------------------=> IMPLEMENTA INTERFAZ

        public bool Eliminar(BE.Categoria_BE objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE.Categoria_BE objeto)
        {
            throw new NotImplementedException();
        }

        public BE.Categoria_BE ListarObjeto(BE.Categoria_BE objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE.Categoria_BE> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
