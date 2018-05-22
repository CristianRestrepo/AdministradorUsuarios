using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    class cOpcion
    {
        private string nombre;
        private string url;
        private cModulo modulo = new cModulo();

        public cModulo Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
