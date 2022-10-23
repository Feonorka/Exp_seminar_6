// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateArray(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)        // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    // 1- columns
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} | ");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateArray(4, 3, -10, 10);

PrintMatrix(array2D);