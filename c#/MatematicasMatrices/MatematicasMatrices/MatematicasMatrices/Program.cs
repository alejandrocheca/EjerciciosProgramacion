using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce las dimensiones de las matrices (filas y columnas):");
        Console.Write("Filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        // Declaración de las matrices
        double[,] matriz1 = new double[filas, columnas];
        double[,] matriz2 = new double[filas, columnas];

        // Ingreso de valores para la primera matriz
        Console.WriteLine("Introduce los valores de la primera matriz:");
        LeerMatriz(matriz1);

        // Ingreso de valores para la segunda matriz
        Console.WriteLine("Introduce los valores de la segunda matriz:");
        LeerMatriz(matriz2);

        // Realizar operaciones y mostrar resultados
        Console.WriteLine("Operaciones matriciales:");
        Console.WriteLine("Matriz 1:");
        ImprimirMatriz(matriz1);

        Console.WriteLine("Matriz 2:");
        ImprimirMatriz(matriz2);

        Console.WriteLine("Suma:");
        double[,] suma = SumarMatrices(matriz1, matriz2);
        ImprimirMatriz(suma);

        Console.WriteLine("Resta:");
        double[,] resta = RestarMatrices(matriz1, matriz2);
        ImprimirMatriz(resta);

        Console.WriteLine("Multiplicación:");
        double[,] multiplicacion = MultiplicarMatrices(matriz1, matriz2);
        ImprimirMatriz(multiplicacion);

        Console.WriteLine("División:");
        double[,] division = DividirMatrices(matriz1, matriz2);
        ImprimirMatriz(division);
    }

    static void LeerMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento ({i + 1},{j + 1}): ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    static double[,] SumarMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        double[,] resultado = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static double[,] RestarMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        double[,] resultado = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }

        return resultado;
    }

    static double[,] MultiplicarMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filasMatriz1 = matriz1.GetLength(0);
        int columnasMatriz1 = matriz1.GetLength(1);
        int filasMatriz2 = matriz2.GetLength(0);
        int columnasMatriz2 = matriz2.GetLength(1);

        if (columnasMatriz1 != filasMatriz2)
        {
            Console.WriteLine("No se pueden multiplicar las matrices. El número de columnas de la matriz 1 debe ser igual al número de filas de la matriz 2.");
            return null;
        }

        double[,] resultado = new double[filasMatriz1, columnasMatriz2];

        for (int i = 0; i < filasMatriz1; i++)
        {
            for (int j = 0; j < columnasMatriz2; j++)
            {
                resultado[i, j] = 0;
                for (int k = 0; k < columnasMatriz1; k++)
                {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }

        return resultado;
    }

    static double[,] DividirMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filasMatriz1 = matriz1.GetLength(0);
        int columnasMatriz1 = matriz1.GetLength(1);
        int filasMatriz2 = matriz2.GetLength(0);
        int columnasMatriz2 = matriz2.GetLength(1);

        if (filasMatriz1 != filasMatriz2 || columnasMatriz1 != columnasMatriz2)
        {
            Console.WriteLine("No se pueden dividir las matrices. Ambas matrices deben tener las mismas dimensiones.");
            return null;
        }

        double[,] resultado = new double[filasMatriz1, columnasMatriz1];

        for (int i = 0; i < filasMatriz1; i++)
        {
            for (int j = 0; j < columnasMatriz1; j++)
            {
                if (matriz2[i, j] == 0)
                {
                    Console.WriteLine("No se puede dividir por cero. La división no es posible.");
                    return null;
                }

                resultado[i, j] = matriz1[i, j] / matriz2[i, j];
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
