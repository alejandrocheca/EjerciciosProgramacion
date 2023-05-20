using System;

namespace Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 9, 1, 3 };

            Console.WriteLine("Array original:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("Array ordenado:");
            PrintArray(array);
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar los elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                // Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado
                if (!swapped)
                    break;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}
