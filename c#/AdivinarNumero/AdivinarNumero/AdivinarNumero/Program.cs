using System;

namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de adivinar el número");
            Console.WriteLine("========================================");
            Console.WriteLine();

            // Generar un número aleatorio entre 1 y 100
            Random random = new Random();
            int numeroAdivinar = random.Next(1, 101);

            int intentos = 0;
            int numeroIngresado;

            do
            {
                Console.Write("Ingrese un número entre 1 y 100: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numeroIngresado))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    continue;
                }

                if (numeroIngresado < 1 || numeroIngresado > 100)
                {
                    Console.WriteLine("El número debe estar entre 1 y 100. Inténtelo de nuevo.");
                    continue;
                }

                intentos++;

                if (numeroIngresado < numeroAdivinar)
                {
                    Console.WriteLine("El número ingresado es demasiado bajo. ¡Inténtalo de nuevo!");
                }
                else if (numeroIngresado > numeroAdivinar)
                {
                    Console.WriteLine("El número ingresado es demasiado alto. ¡Inténtalo de nuevo!");
                }
                else
                {
                    Console.WriteLine($"¡Felicitaciones! Has adivinado el número en {intentos} intentos.");
                }

            } while (numeroIngresado != numeroAdivinar);

            Console.WriteLine("Gracias por jugar. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
