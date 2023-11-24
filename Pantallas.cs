using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public static class Pantallas
    {
        public static string[] respuestas = new string[100];
        public static int cantidadPersonas = 0;
        public static void encuesta()
        {
            Console.Clear();
            Console.Write("===================================\n" +
                      "Nivel de Satisfacción\n" +
                      "===================================\n" +
                      "¿Qué tan satisfecho está con la atención de nuestra tienda?\n" +
                      "1: Nada satisfecho\n" +
                      "2: No muy satisfecho\n" +
                      "3: Tolerable\n" +
                      "4: Satisfecho\n" +
                      "5: Muy satisfecho\n" +
                      "===================================\n" +
                      "Ingrese una opción: \n");
            string respuesta = Console.ReadLine();
            if (EsRespuestaValida(respuesta))
            {
                respuestas[cantidadPersonas] = respuesta;
                cantidadPersonas++;
                Console.Clear();
                Console.Write("===================================\n" +
                      "Nivel de Satisfacción\n" +
                      "===================================\n" +
                      "¡Gracias por participar!\n" +
                      "===================================\n" +
                      "Presione cualquier tecla para regresar al menú ...\n");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.Write("Respuesta no válida. Por favor, ingrese un número del 1 al 5." +
                    "\nPresione cualquier tecla para continuar.");
                Console.ReadKey();
                encuesta();
            }
            Console.Clear();
        }
        public static void DatosRegistrados()
        {
            Console.Clear();
            Console.WriteLine("===================================\n" +
                "Ver datos registrados\n" +
                "===================================");
            datosRegistrados();
            Console.WriteLine("\n===================================");
            Console.WriteLine($"\n{ContarOcurrencias("1"):D2} personas: Nada satisfecho\n" +
                  $"{ContarOcurrencias("2"):D2} personas: No muy satisfecho\n" +
                  $"{ContarOcurrencias("3"):D2} personas: Tolerable\n" +
                  $"{ContarOcurrencias("4"):D2} personas: Satisfecho\n" +
                  $"{ContarOcurrencias("5"):D2} personas: Muy satisfecho\n" +
                  "Presione cualquier tecla para regresar al menú");
            Console.ReadKey();
            Console.Clear();
        }
        public static void eliminarDato()
        {
            Console.Clear();
            Console.WriteLine("===================================\n" +
                  "Eliminar un dato\n" +
                  "===================================");
            datosRegistrados();
            Console.WriteLine("\n===================================" +
                  "\nIngrese la posición a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < cantidadPersonas)
            {
                for (int i = indice; i < cantidadPersonas - 1; i++)
                {
                    respuestas[i] = respuestas[i + 1];
                }
                cantidadPersonas--;
                Console.WriteLine("===================================\n" +
                      "Respuesta eliminada\n" +
                      "===================================\n");
            }
            else
            {
                Console.WriteLine("Índice no válido. Inténtelo de nuevo.");
            }
            datosRegistrados();
            Console.WriteLine("\n===================================");
            Console.Write("\nPresione cualquier tecla para volver al menú\n");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ordenar()
        {
            Console.Clear();
            Console.WriteLine("===================================\n" +
                  "Ordenar datos\n" +
                  "===================================");
            datosRegistrados();
            Console.WriteLine("\nPresione cualquier tecla para ordenar");
            Console.WriteLine("============================================");
            Array.Sort(respuestas, 0, cantidadPersonas);
            Console.Write("");
            Console.ReadKey();
            datosRegistrados();
            Console.WriteLine("\nPresione cualquier tecla para volver al menú");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool EsRespuestaValida(string respuesta)
        {
            return respuesta == "1" || respuesta == "2" || respuesta == "3" || respuesta == "4" || respuesta == "5";
        }
        public static int ContarOcurrencias(string opcion)
        {
            int contador = 0;
            for (int i = 0; i < cantidadPersonas; i++)
            {
                if (respuestas[i] == opcion)
                {
                    contador++;
                }
            }
            return contador;
        }
        
        public static void datosRegistrados()
        {
            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.Write($"{i:D3}:[{respuestas[i]}]");

                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("  ");
                }
            }
        }
        
    }
}
