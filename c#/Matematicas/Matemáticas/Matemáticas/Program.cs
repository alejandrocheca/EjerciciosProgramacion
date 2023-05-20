using System;

namespace Matemáticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones Matemáticas Básicas");
            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.Write("Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Resultados:");
            Console.WriteLine("==========");

            double suma = Sumar(numero1, numero2);
            Console.WriteLine($"Suma: {numero1} + {numero2} = {suma}");

            double resta = Restar(numero1, numero2);
            Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");

            double multiplicacion = Multiplicar(numero1, numero2);
            Console.WriteLine($"Multiplicación: {numero1} * {numero2} = {multiplicacion}");

            if (numero2 != 0)
            {
                double division = Dividir(numero1, numero2);
                Console.WriteLine($"División: {numero1} / {numero2} = {division}");
            }
            else
            {
                Console.WriteLine("División: No se puede dividir entre cero.");
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            return a / b;
        }
    }
}
