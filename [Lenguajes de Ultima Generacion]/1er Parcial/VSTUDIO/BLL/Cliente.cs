using System.Collections.Generic;

namespace BLL
{
    public class Cliente : ABS.IGestor<BEL.Cliente>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.Cliente cliente;
        public Cliente() => this.cliente = new DML.Cliente();


        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.Cliente Detallar(BEL.Cliente cliente) => this.cliente.Detallar(cliente);
        public bool Eliminar(BEL.Cliente cliente) => this.cliente.Eliminar(cliente);
        public bool Guardar(BEL.Cliente cliente) => this.cliente.Guardar(cliente);
        public List<BEL.Cliente> Listar() => cliente.Listar();
        

        // *---------------------------------------------------------=> MÉTODOS
        public bool AgregarTarjetaInternacional(BEL.Cliente cliente, BEL.TarjetaInternacional tarjeta) => this.cliente.AgregarTarjetaInternacional(cliente, tarjeta);
        public bool AgregarTarjetaNacional(BEL.Cliente cliente, BEL.TarjetaNacional tarjeta) => this.cliente.AgregarTarjetaNacional(cliente, tarjeta);
        public bool QuitarTarjetaInternacional(BEL.Cliente cliente, BEL.TarjetaInternacional tarjeta) => this.cliente.QuitarTarjetaInternacional(cliente, tarjeta);
        public bool QuitarTarjetaNacional(BEL.Cliente cliente, BEL.TarjetaNacional tarjeta) => this.cliente.QuitarTarjetaNacional(cliente, tarjeta);
    }
}
