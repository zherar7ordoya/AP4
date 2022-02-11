
// El patrón Data Transfer Object (DTO), se trata de un objeto serializable
// para la transferencia de datos.

namespace App_Registros.DTO
{
    internal class ClientesDTO
    {
        /** Esta clase puede tener:
         *      -Atributos
         *      -Propiedades
         *      -Getters y Setters
         *      -Puede tener constructores
         *  Lo que no puede tener:
         *      -Comportamientos
         *      -Métodos
         */

        int    _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;

        public int    ID        { get => _ID;        set => _ID        = value; }
        public string Nombre    { get => _Nombre;    set => _Nombre    = value; }
        public string Apellido  { get => _Apellido;  set => _Apellido  = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad    { get => _Ciudad;    set => _Ciudad    = value; }
        public string Email     { get => _Email;     set => _Email     = value; }
        public string Telefono  { get => _Telefono;  set => _Telefono  = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
    }
}
