using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FabricaAbstracta
{
    public class LecheAlmendras : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche orgánica de almendra, 250ml.";
        }

        public void Producir()
        {
            WriteLine("Procesar las almendras.");
        }
    }


    public class LecheCoco : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche de coco natural, 250 ml.";
        }

        public void Producir()
        {
            WriteLine("Buscamos los cocos.");
        }
    }



    public class LecheVaca : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Lecha de vaca, 250 ml.";
        }

        public void Producir()
        {
            WriteLine("Ordeñar vaca en la granja.")
        }
    }





    public class SaborChocolate : IProductoSaborizante
    {
        public string Informar()
        {
            return "Sabor a chocolate.";
        }

        public void Obtener()
        {
            WriteLine("Se produce C7H8N4O2.");
        }
    }






    public class VainillaNatural : IProductoSaborizante
    {
        public string Informar()
        {
            return "Extracto natural de vainilla";
        }

        public void Obtener()
        {
            WriteLine("Se extrae de las vainas");
        }
    }



    public class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenerLeche { get { return leche; } }
        public IProductoSaborizante ObtenerSabor { get { return sabor; } }

        public void CrearProducto()
        {
            ForegroundColor = ConsoleColor.Green;
            string seleccion;
            WriteLine("Estamos creando tu bebida");
            WriteLine("1-Almendras 2-Coco");
            seleccion = ReadLine();

            if (seleccion == "1") leche = new LecheAlmendras();
            else { leche = new LecheCoco(); }

            leche.Producir();

            WriteLine("Ahora extraemos el sabor");
            sabor = new VainillaNatural();
            sabor.Obtener();
        }
    }



    public class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenerLeche { get { return leche; } }
        public IProductoSaborizante ObtenerSabor { get { return sabor; } }

        public void CrearProducto()
        {
            WriteLine("Estamos produciendo tu maltaeada.");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
