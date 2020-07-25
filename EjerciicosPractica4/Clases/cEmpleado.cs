using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciicosPractica4.Clases
{
    class cEmpleado
    {
        private string nombre;
        private int sueldo;

        public void Inicializar() {

            Console.WriteLine();
            Console.WriteLine("                     ================ IMPRIMIR DATOS DE LA CLASE EMPLEADO ================");
            Console.WriteLine();

            Console.Write("                         Nombre Empleado: ");
            nombre = Console.ReadLine();

            Console.Write("                         Sueldo Empleado: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void ImprimirDatos() {
            Console.WriteLine();
            Console.Write($"                         El empleado se llama {nombre.ToUpper()} su sueldo es {sueldo}");
        }

        public void PagaImpuesto() {
            Console.WriteLine();
            if (sueldo > 30000)
            {
                Console.Write($"                         El empleado {nombre.ToUpper()} debe pagar impuesto.");
            }
            else
            {
                Console.Write($"                         El empleado {nombre.ToUpper()} no debe pagar impuesto.");
            }
            Console.WriteLine();
        }

        public void RetornarMenu() {
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

    }
}
