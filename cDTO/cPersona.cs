using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    class cPersona
    {
        private Int16 identificacion;
        private string nombre;
        private string apellido;
        private string telefono;
        private int edad;
        private string genero;

        public Int16 Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }


        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
