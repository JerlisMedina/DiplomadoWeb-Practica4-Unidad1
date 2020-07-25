using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciicosPractica4.Clases;

namespace EjerciicosPractica4.Clases
{
    class cSocio
    {
        private string nombre;
        private int antiguedad;

        public cSocio(string Nombre, int Antiguedad) {
            nombre = Nombre;
            antiguedad = Antiguedad;
        }

        public string RetornarNombre() {
            return nombre;
        }

        public int RetornarAntiguedad() {
            return antiguedad;
        }
    }
}
