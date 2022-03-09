namespace Parte1
{
    public class Estudiante
    {
        public Estudiante(string nombre, string iD, string curso, double promedio)
        {
            Nombre = nombre;
            ID = iD;
            Curso = curso;
            Promedio = promedio;
        }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public string Curso { get; set; }
        public double Promedio { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"\nID: {ID}" +
                $"\nNombre: {Nombre}" +
                $"\nCurso: {Curso}" +
                $"\nPromedio: {Promedio}");
        }
    }
}
