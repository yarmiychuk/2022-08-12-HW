/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
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

int[,] array = CreateRandom2DArray(rnd.Next(2, 10), rnd.Next(2, 10), 0, 9);
Console.WriteLine($"Двумерный массив {array.GetLength(0)} x {array.GetLength(1)}:");
Show2DArray(array);

Console.WriteLine("Выберите позицию M и N в массиве для отображения значения");
Console.Write("Введите индекс M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= array.GetLength(0) || n >= array.GetLength(1))
    Console.WriteLine($"Ячейки с индексом [{m}, {n}] не существует!");
else
    Console.WriteLine($"Значение ячеки с индексом [{m}, {n}] в массиве равно {array[m, n]}");

