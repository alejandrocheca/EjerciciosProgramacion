using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un DNI: ");
        string dni = Console.ReadLine();

        if (ValidarDNI(dni))
        {
            Console.WriteLine("El DNI es válido.");
        }
        else
        {
            Console.WriteLine("El DNI no es válido.");
        }
    }

    static bool ValidarDNI(string dni)
    {
        if (string.IsNullOrEmpty(dni) || dni.Length != 9)
            return false;

        dni = dni.ToUpper(); // Convierte a mayúsculas para evitar errores de letra

        // Extraer los números del DNI
        string numeros = dni.Substring(0, 8);
        string letra = dni.Substring(8, 1);

        if (!int.TryParse(numeros, out int numero))
            return false;

        // Calcular la letra esperada
        char letraCalculada = CalcularLetraDNI(numero);

        // Comparar la letra esperada con la letra proporcionada
        return letraCalculada == letra[0];
    }

    static char CalcularLetraDNI(int numero)
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int indice = numero % 23;
        return letras[indice];
    }
}
