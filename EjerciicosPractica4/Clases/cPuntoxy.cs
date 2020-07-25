using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciicosPractica4.Clases
{
    class cPuntoxy
    {
        private int x;
        private int y;

        public void Inicializar() {
            Console.WriteLine();
            Console.WriteLine("                     ================ CUADRANTE DE UN PUNTO EN EL PLANO DE COORDENADAS ================");
            Console.WriteLine();

            Console.Write("                         Introduzca el valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("                         Introduzca el valor de Y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void CargarValores() {
            Console.WriteLine();
            Console.Write($"                         Valor de x = {x} Valor de y = {y}, Punto (x,y) = ({x},{y})");
        }

        public void CuadrantePuntoxy() {
            Console.WriteLine();
            if (x > 0 && y > 0)
            {
                Console.Write($"                         El Punto (x,y) = ({x},{y}) se encuentra en el Cuadrante I");
            }

            if (x < 0 && y > 0)
            {
                Console.Write($"                         El Punto (x,y) = ({x},{y}) se encuentra en el Cuadrante II");
            }

            if (x < 0 && y < 0)
            {
                Console.Write($"                         El Punto (x,y) = ({x},{y}) se encuentra en el Cuadrante III");
            }

            if (x > 0 && y < 0)
            {
                Console.Write($"                         El Punto (x,y) = ({x},{y}) se encuentra en el Cuadrante IV");
            }
        }

        public void RetornarMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
