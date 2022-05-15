using System.Collections.Generic;

namespace BLL
{
    public class EquipoBLL
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Color { get; set; }

        //Relación 1 a 1
        public TecnicoBLL Tecnico { get; set; }

        //Relación 1 a Muchos
        public List<AJugadorBLL> ListaJugadores = new List<AJugadorBLL>();
        #endregion

        #region Métodos
        public int ObtenerPuntajeEquipo()
        {
            int ptos = 0;
            foreach (AJugadorBLL jugador in ListaJugadores) ptos += jugador.ObtenerPuntaje();
            return ptos;
        }
        #endregion
    }
}
