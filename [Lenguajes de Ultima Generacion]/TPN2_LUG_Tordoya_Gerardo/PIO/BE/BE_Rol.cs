﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Rol : Entidad
    {
        public string RolID { get; set; }
        public string Nombre { get; set; }
        public string Instruccion { get; set; }
    }
}
