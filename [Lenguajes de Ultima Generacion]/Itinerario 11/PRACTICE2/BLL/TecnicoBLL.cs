using System;

namespace BLL
{
    public class TecnicoBLL
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        #region Constructores
        //constructor vacio
        public TecnicoBLL() { }

        //constructor sobrecargado
        public TecnicoBLL(string _Nom, String _Ape, int _DNI)
        {
            Nombre = _Nom;
            Apellido = _Ape;
            DNI = _DNI;
        }
        #endregion

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + this.DNI + " ";
        }
    }
}
