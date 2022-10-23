// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
        Console.WriteLine("Сгенерированный массив:");
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int LineMatrixMaker(int[,] matrix)
{
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? 1 : 0;
    int summM = default;
    for (int i = 0; i < matrix.GetLength(count); i++)
    {
        summM += matrix[i, i];
    }
    return summM;
}

int[,] array2D = CreateMatrixRndInt(4, 3, -10, 10);

PrintMatrix(array2D);

int _array2D = LineMatrixMaker(array2D);
Console.WriteLine(_array2D);