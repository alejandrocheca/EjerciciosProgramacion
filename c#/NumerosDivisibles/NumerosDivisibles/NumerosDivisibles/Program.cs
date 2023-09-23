using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el número máximo del rango: ");
        int maximo = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el número por el cual deseas verificar la divisibilidad: ");
        int divisor = int.Parse(Console.ReadLine());

        Console.WriteLine($"Números divisibles por {divisor} en el rango de 1 a {maximo}:");

        for (int i = 1; i <= maximo; i++)
        {
            if (i % divisor == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
