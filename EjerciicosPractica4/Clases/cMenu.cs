using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciicosPractica4.Clases;

namespace EjerciicosPractica4.Clases
{
    class cMenu
    {
        public void mostrar()
        {
            string opcion = "";
            cEmpleado nEmpleado = new cEmpleado();
            cPuntoxy nPunto = new cPuntoxy();
            cClub nClub = new cClub();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                     UNIVERSIDAD AUTONOMA DE SANTO DOMINGO      ");
                Console.WriteLine("                                                     UASD      ");
                Console.WriteLine("                                              FACULTAD DE CIENCIAS      ");
                Console.WriteLine("                                             ESCUELA DE INFORMATICA     ");

                Console.WriteLine("                                               PRACTICA NUMERO IV      ");
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine();


                Console.WriteLine("                     **************** ELIJA UNA OPCION DEL SIGUIENTE MENU *********************");
                Console.WriteLine("                               1 - Clase Empleado (Ejercicio 1).");
                Console.WriteLine("                               2 - Clase Punto En El Plano (Ejercicio 2).");
                Console.WriteLine("                               3 - Clase Club Socio (Ejercicio 3).");
                Console.WriteLine("                               S - Presione la tecla 'S' para salir");
                Console.WriteLine("                     *************************************************************************");
                Console.WriteLine();
                Console.Write("                         Seleccione Una Opcion: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        nEmpleado.Inicializar();
                        nEmpleado.ImprimirDatos();
                        nEmpleado.PagaImpuesto();
                        nEmpleado.RetornarMenu();
                        break;

                    case "2":
                        nPunto.Inicializar();
                        nPunto.CargarValores();
                        nPunto.CuadrantePuntoxy();
                        nPunto.RetornarMenu();
                        break;

                    case "3":
                        nClub.Inicializar();
                        nClub.ImprimirDatos();
                        nClub.RetornarMenu();
                        break;

                    default:
                        Console.Write("                                      <<<<<<<<<<< Hasta pronto!!! >>>>>>>>>>");
                        opcion = "s";
                        break;
                }

            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();

        }
    }
}
