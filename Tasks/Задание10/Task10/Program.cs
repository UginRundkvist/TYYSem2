using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элементы первой матрицы:");
        int[,] sourceMatrix = ReadMatrix(n);

        Console.WriteLine("Введите элементы второй матрицы:");
        int[,] targetMatrix = ReadMatrix(n);

        TransferNonDiagonalElements(sourceMatrix, targetMatrix);

        Console.WriteLine("Первая матрица после изменений:");
        PrintMatrix(sourceMatrix);

        Console.WriteLine("Вторая матрица после изменений:");
        PrintMatrix(targetMatrix);
    }

    static int[,] ReadMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static void TransferNonDiagonalElements(int[,] source, int[,] target)
    {
        int size = source.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i != j && i + j != size - 1) 
                {
                    target[i, j] = source[i, j];
                    source[i, j] = -1;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        int maxLength = 0;

        foreach (int num in matrix)
        {
            maxLength = Math.Max(maxLength, num.ToString().Length);
        }

        string separator = new string('-', (maxLength + 2) * size + 2);
        Console.WriteLine(separator);
        for (int i = 0; i < size; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(maxLength) + " ");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine(separator);
    }
}
