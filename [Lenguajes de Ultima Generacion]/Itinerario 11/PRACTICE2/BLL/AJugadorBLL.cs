﻿namespace BLL
{
    public abstract class AJugadorBLL
    {
        public string Nombre { get; set; }
        public int CantidadAmarillas { get; set; }
        public int CantidadRojas { get; set; }
        public int GolesRealizados { get; set; }
        public abstract int ObtenerPuntaje();
    }
}
