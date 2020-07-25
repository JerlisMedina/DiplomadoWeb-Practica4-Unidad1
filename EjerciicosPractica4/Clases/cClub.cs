using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciicosPractica4.Clases;

namespace EjerciicosPractica4.Clases
{
    class cClub
    {
        cSocio socio1, socio2, socio3;
        public cClub() {
            socio1 = new cSocio("Pablo Minaya",5);
            socio2 = new cSocio("Juan Padilla",3);
            socio3 = new cSocio("Mario Perez",7);
        }

        public void Inicializar()
        {
            Console.WriteLine();
            Console.WriteLine("                     ================ IMPRIMIR SOCIO CON MAYOR TIEMPO EN UN CLUB ================");
            Console.WriteLine();

        }

        public void ImprimirDatos() {
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() && socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                Console.WriteLine();
                Console.Write($"                    El socio con mayor tiempo en el club es {socio1.RetornarNombre().ToUpper()} con {socio1.RetornarAntiguedad()} años.");
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    Console.WriteLine();
                    Console.Write($"                    El socio con mayor tiempo en el club es {socio2.RetornarNombre().ToUpper()} con {socio2.RetornarAntiguedad()} años.");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write($"                    El socio con mayor tiempo en el club es {socio3.RetornarNombre().ToUpper()} con {socio3.RetornarAntiguedad()} años.");
                }
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
