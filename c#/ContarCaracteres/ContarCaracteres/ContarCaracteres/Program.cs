using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine();

        // Contar la cantidad total de caracteres
        int totalCaracteres = texto.Length;

        // Contar la cantidad de signos ortográficos (no letras ni números)
        int signosOrtograficos = texto.Count(c => !Char.IsLetterOrDigit(c));

        // Crear un diccionario para almacenar la frecuencia de cada letra
        Dictionary<char, int> frecuenciaLetras = new Dictionary<char, int>();

        // Iterar a través del texto para contar las letras
        foreach (char caracter in texto)
        {
            if (Char.IsLetter(caracter))
            {
                char letra = Char.ToLower(caracter); // Tratar las letras como minúsculas para evitar distinción entre mayúsculas y minúsculas
                if (frecuenciaLetras.ContainsKey(letra))
                {
                    frecuenciaLetras[letra]++;
                }
                else
                {
                    frecuenciaLetras[letra] = 1;
                }
            }
        }

        // Ordenar el diccionario por clave (letras) en orden alfabético
        var letrasOrdenadas = frecuenciaLetras.OrderBy(pair => pair.Key);

        // Mostrar resultados
        Console.WriteLine($"Cantidad total de caracteres: {totalCaracteres}");
        Console.WriteLine($"Cantidad de signos ortográficos: {signosOrtograficos}");

        Console.WriteLine("Frecuencia de letras (en orden alfabético):");
        foreach (var par in letrasOrdenadas)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
    }
}
