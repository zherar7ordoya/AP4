﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__L_
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        // Se crea como abstracto para que lo implemente cada clase que hereda.
        public abstract void Muestra();
    }
}
