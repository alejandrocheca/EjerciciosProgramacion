using System;

class SudokuSolver
{
    static void Main()
    {
        int[,] sudokuBoard = {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

        Console.WriteLine("Sudoku inicial:");
        PrintSudoku(sudokuBoard);

        if (SolveSudoku(sudokuBoard))
        {
            Console.WriteLine("\nSudoku resuelto:");
            PrintSudoku(sudokuBoard);
        }
        else
        {
            Console.WriteLine("\nNo hay solución para el Sudoku.");
        }
    }

    static bool SolveSudoku(int[,] board)
    {
        int row, col;

        if (!FindUnassignedLocation(board, out row, out col))
        {
            // Si no hay celdas no asignadas, el Sudoku está resuelto
            return true;
        }

        // Intentar asignar números del 1 al 9
        for (int num = 1; num <= 9; num++)
        {
            if (IsSafe(board, row, col, num))
            {
                // Asignar el número si es seguro
                board[row, col] = num;

                // Llamada recursiva para la siguiente celda
                if (SolveSudoku(board))
                {
                    return true; // Se encontró una solución
                }

                // Deshacer la asignación si no lleva a una solución
                board[row, col] = 0;
            }
        }

        // No hay solución para este estado
        return false;
    }

    static bool FindUnassignedLocation(int[,] board, out int row, out int col)
    {
        for (row = 0; row < 9; row++)
        {
            for (col = 0; col < 9; col++)
            {
                if (board[row, col] == 0)
                {
                    return true; // Hay una celda no asignada
                }
            }
        }

        row = -1;
        col = -1;
        return false; // No hay celdas no asignadas
    }

    static bool IsSafe(int[,] board, int row, int col, int num)
    {
        // Verificar que el número no esté presente en la misma fila ni en la misma columna
        for (int x = 0; x < 9; x++)
        {
            if (board[row, x] == num || board[x, col] == num)
            {
                return false;
            }
        }

        // Verificar que el número no esté presente en el mismo bloque 3x3
        int startRow = row - row % 3;
        int startCol = col - col % 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[startRow + i, startCol + j] == num)
                {
                    return false;
                }
            }
        }

        return true; // Es seguro asignar el número en esta celda
    }

    static void PrintSudoku(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
