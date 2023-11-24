using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Write("================================\n" +
                  "Encuestas de Calidad\n" +
                  "================================\n" +
                  "1: Realizar Encuesta\n" +
                  "2: Ver datos registrados\n" +
                  "3: Eliminar un dato\n" +
                  "4: Ordenar datos de menor a mayor\n" +
                  "5: Salir\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: Pantallas.encuesta(); break;
                        case 2: Pantallas.DatosRegistrados(); break;
                        case 3: Pantallas.eliminarDato(); break;
                        case 4: Pantallas.ordenar(); break;
                        case 5: Console.Clear(); break;
                        default:
                            Console.Clear(); Console.Write("Opción no válida. Inténtelo de nuevo." +
                            "\nPrecione cualquier tecla para continuar"); Console.ReadKey(); break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Por favor, ingrese un número válido." +
                          "\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 5);
        }
    }
}
