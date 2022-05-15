namespace BLL
{
    public class PrincipianteBLL : AJugadorBLL
    {
        public bool Rapado { get; set; }

        public override int ObtenerPuntaje()
        {
            int puntaje = 10 * GolesRealizados - 2 * CantidadRojas - 2 * CantidadAmarillas;
            return puntaje;
        }
    }
}
