using System;

class Program
{
    static void Main()
    {
        // Ejemplo 1
        try
        {
            string a = "abcz";
            int b = 26;
            string result1 = LexicographicallySmallestBeautifulString(a, b);
            Console.WriteLine(result1); // Debería imprimir "abda"
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Ejemplo 2
        try
        {
            string c = "dc";
            int d = 4;
            string result2 = LexicographicallySmallestBeautifulString(c, d);
            Console.WriteLine(result2); // Debería imprimir ""
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static string LexicographicallySmallestBeautifulString(string s, int k)
    {
        char[] result = s.ToCharArray();
        int n = s.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (result[i] != 'a' && result[i] < 'a' + k - 1)
            {
                result[i]++;
                for (int j = i + 1; j < n; j++)
                {
                    result[j] = 'a';
                }

                return new string(result);
            }
        }

        return string.Empty;
    }
}
