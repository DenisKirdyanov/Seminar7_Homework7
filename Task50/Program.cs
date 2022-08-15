// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            result[i, j] = new Random().Next(min, max + 1);
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

Console.WriteLine("Введите позицию элемента в массиве: ");
int indexRow = int.Parse(Console.ReadLine());
int indexColumn = int.Parse(Console.ReadLine());
GetValue(array, indexRow, indexColumn);

void GetValue(double[,] lArray, int loci, int locj)
{
    if (loci > lArray.GetLength(0) || locj > lArray.GetLength(1)) Console.WriteLine("Нет такого элеента!");
    else Console.WriteLine(lArray[loci, locj]);
}


