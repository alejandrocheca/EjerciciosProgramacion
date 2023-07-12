using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5]; // Array de tamaño 5 para almacenar números
        int indice = 0; // Índice actual del array

        Console.WriteLine("Ingresa 5 números:");

        while (indice < 5)
        {
            Console.Write("Ingresa un número: ");
            string input = Console.ReadLine();

            // Verifica si el número ingresado es válido
            if (!int.TryParse(input, out int numeroIngresado))
            {
                Console.WriteLine("¡El número ingresado no es válido!");
                continue;
            }

            numeros[indice] = numeroIngresado;
            indice++;
        }

        Console.WriteLine("\nNúmeros ingresados:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.ReadLine();
    }
}
