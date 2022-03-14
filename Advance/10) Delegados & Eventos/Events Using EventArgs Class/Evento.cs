using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Using_EventArgs_Class
{
    public class Evento : EventArgs
    {
        public string Mensaje;
        public static event EventHandler<Evento> manejador;

        public Evento(string mensaje) => Mensaje = mensaje;
        public Evento() { }

        protected virtual void OnChange(Evento e) => manejador?.Invoke(this, e);
        public void EnviarMensaje(string información) => OnChange(new Evento(información));
    }
}
