using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Categoria : ABSTRACTA.IGestor<BE.BE_Categoria>
    {
        readonly MPP.MPP_Categoria MPP_CATEGORIA;
        public BLL_Categoria() => MPP_CATEGORIA = new MPP.MPP_Categoria();

        //__________________________________________________IMPLEMENTA INTERFAZ

        public bool Eliminar(BE_Categoria categoria)
        {
            return MPP_CATEGORIA.Eliminar(categoria);
        }


        public bool Guardar(BE_Categoria categoria)
        {
            return MPP_CATEGORIA.Guardar(categoria);
        }


        public BE_Categoria ListarObjeto(BE_Categoria objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Categoria> ListarTodo()
        {
            return MPP_CATEGORIA.ListarTodo();
        }
    }
}
