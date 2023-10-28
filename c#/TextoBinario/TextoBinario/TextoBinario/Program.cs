using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        byte[] bytes = Encoding.UTF8.GetBytes(texto);

        Console.WriteLine("Texto en binario:");
        foreach (byte b in bytes)
        {
            Console.Write(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
        }
    }
}
