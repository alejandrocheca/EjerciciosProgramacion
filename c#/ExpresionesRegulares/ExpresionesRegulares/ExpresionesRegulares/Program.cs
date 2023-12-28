﻿using System;

class Program
{
    static void Main()
    {
        // Ejemplo 1
        Console.WriteLine(IsMatch("aa", "a")); // Output: False

        // Ejemplo 2
        Console.WriteLine(IsMatch("aa", "a*")); // Output: True

        // Ejemplo 3
        Console.WriteLine(IsMatch("ab", ".")); // Output: True
    }

    static bool IsMatch(string s, string p)
    {
        // Inicializar la matriz de coincidencia
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;

        // Llenar la primera fila de la matriz
        for (int j = 1; j <= p.Length; j++)
        {
            if (p[j - 1] == '*')
            {
                dp[0, j] = dp[0, j - 2];
            }
        }

        // Llenar el resto de la matriz
        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else if (p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                }
            }
        }

        return dp[s.Length, p.Length];
    }
}
