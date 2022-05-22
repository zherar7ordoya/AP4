using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TarjetaInternacional : Tarjeta, ABS.IGestor<BEL.TarjetaInternacional>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.TarjetaInternacional tarjeta;
        public TarjetaInternacional() => this.tarjeta = new DML.TarjetaInternacional();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.TarjetaInternacional Detallar(BEL.TarjetaInternacional tarjeta) => this.tarjeta.Detallar(tarjeta);
        public bool Eliminar(BEL.TarjetaInternacional tarjeta) => this.tarjeta.Eliminar(tarjeta);
        public bool Guardar(BEL.TarjetaInternacional tarjeta) => this.tarjeta.Guardar(tarjeta);
        public List<BEL.TarjetaInternacional> Listar() => this.tarjeta.Listar();
        public override double ObtenerDescuento(double importe) => importe * 0.70;

        // *------------------------------------------------=> MÉTODOS
        public List<BEL.TarjetaInternacional> ListarDisponibles() => this.tarjeta.ListarDisponibles();
    }
}
