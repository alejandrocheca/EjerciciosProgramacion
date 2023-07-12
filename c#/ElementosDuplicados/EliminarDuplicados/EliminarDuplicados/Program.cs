using System;
using System.Text;

namespace EliminarDuplicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un texto:");
            string texto = Console.ReadLine();

            string textoSinLetrasRepetidas = EliminarLetrasRepetidas(texto);

            Console.WriteLine("Texto sin letras repetidas:");
            Console.WriteLine(textoSinLetrasRepetidas);

            Console.ReadLine();
        }

        static string EliminarLetrasRepetidas(string texto)
        {
            StringBuilder sb = new StringBuilder();
            char letraAnterior = '\0'; // Carácter nulo para la primera letra

            foreach (char letra in texto)
            {
                if (letra != letraAnterior)
                {
                    sb.Append(letra);
                }
                letraAnterior = letra;
            }

            return sb.ToString();
        }
    }
}
