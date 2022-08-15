// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Sqrt(new Random().Next(min, max + 1));
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(rows, columns, 0, 50);

PrintArray(array);

