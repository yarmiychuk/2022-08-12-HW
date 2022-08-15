/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
*/

Random rnd = new Random();

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void ShowAverages(int[,] array)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        double ySum = 0;
        int xLenght = array.GetLength(0);

        for (int x = 0; x < xLenght; x++)
            ySum += array[x, y];

        Console.Write(ySum / xLenght);
        if (y != array.GetLength(1) - 1)
            Console.Write(", ");

    }
    Console.WriteLine();
}

int[,] array = CreateRandom2DArray(rnd.Next(3, 10), rnd.Next(3, 10), 0, 9);
Show2DArray(array);
Console.WriteLine("Средние арифметические в каждом солбце массива равны:");
ShowAverages(array);