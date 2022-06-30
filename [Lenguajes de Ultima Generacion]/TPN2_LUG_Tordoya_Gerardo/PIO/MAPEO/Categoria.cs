using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPEO
{
    public class Categoria : ABSTRACCION.IGestor<BE.Categoria>
    {
        // *----------------------------------------------=> VARIABLES DE CLASE
        
        readonly DA.Conexion conexion;
        Hashtable htabla;

        // *---------------------------------------------------=> CONSTRUCTORES

        public Categoria() => conexion = new DA.Conexion();

        // *------------------------------------=> IMPLEMENTACIÓN DE INTERFACES

        public bool Eliminar(BE.Categoria objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE.Categoria objeto)
        {
            throw new NotImplementedException();
        }

        public BE.Categoria ListarObjeto(BE.Categoria objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE.Categoria> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
