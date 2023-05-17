using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string input = Console.ReadLine();
        int[] numeros = ParseInput(input);

        Console.WriteLine("Números ingresados:");
        PrintArray(numeros);

        BubbleSort(numeros);

        Console.WriteLine("Números ordenados:");
        PrintArray(numeros);
    }

    public static int[] ParseInput(string input)
    {
        string[] numerosString = input.Split(' ');
        int[] numeros = new int[numerosString.Length];

        for (int i = 0; i < numerosString.Length; i++)
        {
            numeros[i] = int.Parse(numerosString[i]);
        }

        return numeros;
    }

    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (array[i - 1] > array[i])
                {
                    Swap(array, i - 1, i);
                    swapped = true;
                }
            }

            n--;
        }
        while (swapped);
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
