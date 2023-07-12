using System;

class Program
{
    static void Main(string[] args)
    {
        const int maximoNumeros = 100; // Tamaño máximo del array
        int[] numeros = new int[maximoNumeros]; // Array para almacenar los números
        int cantidadNumeros = 0; // Cantidad actual de números ingresados

        Console.WriteLine("Ingresa números para almacenar en el array. Ingresa un número negativo para finalizar.");

        // Ingreso de números en el array
        while (cantidadNumeros < maximoNumeros)
        {
            Console.Write("Ingresa un número: ");
            string input = Console.ReadLine();

            // Verifica si el número ingresado es válido
            if (!int.TryParse(input, out int numeroIngresado))
            {
                Console.WriteLine("¡El número ingresado no es válido!");
                continue;
            }

            // Verifica si el número ingresado es negativo para finalizar el programa
            if (numeroIngresado < 0)
                break;

            numeros[cantidadNumeros] = numeroIngresado;
            cantidadNumeros++;
        }

        Console.WriteLine("\nNúmeros ingresados en el orden en que fueron ingresados:");

        // Imprime los números ingresados en el orden en que fueron ingresados
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("\nNúmeros ingresados en orden ascendente:");

        // Ordena los números de forma ascendente y los imprime
        Array.Sort(numeros, 0, cantidadNumeros);
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("\nNúmeros ingresados en orden descendente:");

        // Ordena los números de forma descendente y los imprime
        Array.Reverse(numeros, 0, cantidadNumeros);
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.ReadLine();
    }
}
