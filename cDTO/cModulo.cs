﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    class cModulo
    {
        private string nombre;
        private cAplicacion aplicacion = new cAplicacion();

        public cAplicacion Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
