using System;
using System.Collections.Generic;

namespace EjemploWhile
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Números (Ingrese 0 para terminar)");
            Console.WriteLine("========================================");
            Console.WriteLine();

            List<int> numeros = IngresarNumeros();

            Console.WriteLine();
            Console.WriteLine($"Cantidad de números ingresados: {numeros.Count}");

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static List<int> IngresarNumeros()
        {
            List<int> numeros = new List<int>();

            int numero;
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numero))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    continue;
                }

                if (numero == 0)
                {
                    continuar = false;
                }
                else
                {
                    numeros.Add(numero);
                }
            }

            return numeros;
        }
    }
}