using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    public interface IFabrica
    {
        void CrearProducto();
        IProductoLeche ObtenerLeche { get; }
        IProductoSaborizante ObtenerSabor { get; }
    }


    public interface IProductoLeche
    {
        void Producir();
        string ObtenerDatos();
    }


    public interface IProductoSaborizante
    {
        void Obtener();
        string Informar();
    }
}
