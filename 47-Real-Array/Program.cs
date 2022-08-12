/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
*/

Random rnd = new Random();

double[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rnd.Next(minValue, maxValue + 1) + rnd.NextDouble();
        }
    }
    return newArray;
}

void Show2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetRandomInt()
{
    return rnd.Next(1, 10);
}

double[,] array = CreateRandom2DArray(GetRandomInt(), GetRandomInt(), 0, 10);
Show2DArray(array);