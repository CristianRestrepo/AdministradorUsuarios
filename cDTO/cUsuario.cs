using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    class cUsuario
    {
        private string clave;
        private string contraseña;
        private cPersona persona = new cPersona();

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public cPersona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }


    }
}
