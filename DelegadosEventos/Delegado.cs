using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    // Cada entidad (un delegado es una entidad) debe tener su propia clase.
    // Un delegado es una variable que contiene una función.

    // Aquí defino qué tipo de funciones puede contener.
    // En este caso, una void que reciba un parámetro int.
    public delegate void DelegadoVoidEntero(int entero);
    public delegate void DelegadoVoidCadena(string cadena);
}
