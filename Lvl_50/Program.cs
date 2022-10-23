//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите строку искомого элемента массива:");
int numR = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента массива:");
int numC = Convert.ToInt32(Console.ReadLine());

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

void ElementFinder(int[,] arr, int row, int col)
{
    if (arr.GetLength(0) >= row && arr.GetLength(1) >= col) Console.WriteLine($"Искомое значение: {arr[row, col]}");
    else Console.WriteLine($"{row}, {col} -> Элемент отсутствует");
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

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
ElementFinder(array2D, numR, numC);