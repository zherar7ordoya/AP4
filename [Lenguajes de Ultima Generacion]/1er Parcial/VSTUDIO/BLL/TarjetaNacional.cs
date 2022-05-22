using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TarjetaNacional : Tarjeta, ABS.IGestor<BEL.TarjetaNacional>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.TarjetaNacional tarjeta;
        public TarjetaNacional() => this.tarjeta = new DML.TarjetaNacional();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public override double ObtenerDescuento(double importe) => importe * 0.75;
        public BEL.TarjetaNacional Detallar(BEL.TarjetaNacional tarjeta) => this.tarjeta.Detallar(tarjeta);
        public bool Eliminar(BEL.TarjetaNacional tarjeta) => this.tarjeta.Eliminar(tarjeta);
        public bool Guardar(BEL.TarjetaNacional tarjeta) => this.tarjeta.Guardar(tarjeta);
        public List<BEL.TarjetaNacional> Listar() => this.tarjeta.Listar();

        // *---------------------------------------------------------=> MÉTODOS
        public List<BEL.TarjetaNacional> ListarDisponibles() => this.tarjeta.ListarDisponibles();
    }
}
