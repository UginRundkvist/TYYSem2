using System;

class MatrixProcessor
{
    public static int[,] ProcessMatrices(int[,] baseMatrix, int[,] sourceMatrix)
    {
        int rows = Math.Min(baseMatrix.GetLength(0), sourceMatrix.GetLength(0));
        int cols = Math.Min(baseMatrix.GetLength(1), sourceMatrix.GetLength(1));
        int[,] resultMatrix = (int[,])baseMatrix.Clone();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i != j) 
                {
                    resultMatrix[i, j] = -1;
                }
            }
        }
        return resultMatrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int cellWidth = 5; 

        Console.WriteLine(new string('-', cols * cellWidth));
        for (int i = 0; i < rows; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(cellWidth - 1) + " ");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine(new string('-', cols * cellWidth));
    }

    public static int[,] InputMatrix(int rows, int cols, string name)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine($"Введите элементы матрицы {name} ({rows}x{cols}):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static void Main()
    {
        Console.Write("Введите количество строк и столбцов для матрицы A: ");
        int rowsA = int.Parse(Console.ReadLine());
        int colsA = int.Parse(Console.ReadLine());
        int[,] matrixA = InputMatrix(rowsA, colsA, "A");

        Console.Write("Введите количество строк и столбцов для матрицы B: ");
        int rowsB = int.Parse(Console.ReadLine());
        int colsB = int.Parse(Console.ReadLine());
        int[,] matrixB = InputMatrix(rowsB, colsB, "B");

        Console.WriteLine("Исходная матрица A:");
        PrintMatrix(matrixA);

        int[,] resultMatrix = ProcessMatrices(matrixB, matrixA);
        Console.WriteLine("Матрица B после обработки матрицы A:");
        PrintMatrix(resultMatrix);
    }
}
