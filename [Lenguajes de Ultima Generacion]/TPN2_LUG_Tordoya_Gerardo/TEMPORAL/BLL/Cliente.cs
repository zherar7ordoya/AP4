using System.Collections.Generic;

namespace BLL
{
    public class Cliente : Abstraccion.IGestor<BE.Cliente>
    {
        //defino el objeto del mapper usuario
        readonly MPP.Cliente cliente;


        public Cliente()
        {   //lo instancio en el constructor de la BLL
            cliente = new MPP.Cliente();
        }


        public List<BE.Cliente> ListarTodo()
        {
            return cliente.ListarTodo();
        }


        public bool Guardar(BE.Cliente _cliente)
        {
            return cliente.Guardar(_cliente);
        }


        public bool Eliminar(BE.Cliente _cliente)
        {
            return cliente.Eliminar(_cliente);
        }


        public List<BE.Cliente> BuscarClienteXApellido(BE.Cliente _cliente)
        {
            return cliente.BuscarClienteXApellido(_cliente);
        }


        public BE.Cliente ListarObjeto(BE.Cliente _cliente)
        {
            throw new System.NotImplementedException();
        }


    }
}
