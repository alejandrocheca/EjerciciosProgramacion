using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un texto: ");
        string texto = Console.ReadLine();

        string textoAlReves = ReversoTexto(texto);

        Console.WriteLine("Texto al revés: ");
        Console.WriteLine(textoAlReves);
    }

    static string ReversoTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
