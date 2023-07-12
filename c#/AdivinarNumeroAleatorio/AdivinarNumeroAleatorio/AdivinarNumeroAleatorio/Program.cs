using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int adivinarNumero = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100

        Console.WriteLine("Adivina el número generado (entre 1 y 100).");

        int intentos = 0;
        int numeroIngresado;

        do
        {
            Console.Write("Ingresa tu número: ");
            string input = Console.ReadLine();

            // Verifica si el número ingresado es válido
            if (!int.TryParse(input, out numeroIngresado))
            {
                Console.WriteLine("¡El número ingresado no es válido!");
                continue;
            }

            intentos++;

            if (numeroIngresado < adivinarNumero)
            {
                Console.WriteLine("El número ingresado es menor que el número a adivinar. Intenta de nuevo.");
            }
            else if (numeroIngresado > adivinarNumero)
            {
                Console.WriteLine("El número ingresado es mayor que el número a adivinar. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine("¡Felicidades! ¡Has adivinado el número correctamente!");
                Console.WriteLine("Número de intentos: " + intentos);
            }

        } while (numeroIngresado != adivinarNumero);

        Console.ReadLine();
    }
}
