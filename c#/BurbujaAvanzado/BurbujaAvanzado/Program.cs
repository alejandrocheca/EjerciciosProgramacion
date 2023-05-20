using System;

namespace BurbujaAvanzado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] array = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array original:");
            PrintArray(array);

            BubbleSortASC(array);

            Console.WriteLine("Array ordenado ascendentemente:");
            PrintArray(array);

            BubbleSortDESC(array);

            Console.WriteLine("Array ordenado descendentemente:");
            PrintArray(array);


        }

        static void BubbleSortASC(int[] array)
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
        static void BubbleSortDESC(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
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
