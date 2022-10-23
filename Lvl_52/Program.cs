// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)        // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    // 1- columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}

double[] MidleArifmetic(int[,] matrix)
{
double[] arr = new double[matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)        
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    
        {
            arr[j] += Math.Round(matrix[i, j] / Convert.ToDouble(matrix.GetLength(0)), 2, MidpointRounding.AwayFromZero);
        }
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 4} |");
        else Console.Write($"{arr[i], 4}");
    }
    Console.Write("|");
}


int[,] array2D = CreateMatrixRndInt(9, 9, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
double[] arrOf = MidleArifmetic(array2D);
PrintArray(arrOf);