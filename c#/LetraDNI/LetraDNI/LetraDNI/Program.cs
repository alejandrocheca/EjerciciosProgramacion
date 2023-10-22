using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el número de DNI (sin la letra): ");
        string numeroDNI = Console.ReadLine();

        if (int.TryParse(numeroDNI, out int numero))
        {
            char letra = CalcularLetraDNI(numero);
            Console.WriteLine($"La letra correspondiente al número de DNI {numero} es: {letra}");
        }
        else
        {
            Console.WriteLine("El número de DNI no es válido. Debe ser un número entero.");
        }
    }

    static char CalcularLetraDNI(int numero)
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int indice = numero % 23;
        return letras[indice];
    }
}
