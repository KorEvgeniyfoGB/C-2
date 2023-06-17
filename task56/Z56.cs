// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

int Prompt(string message)  //Проверка на число
{
    Console.Write(message);
    string num = Console.ReadLine()!;
    bool realNum = int.TryParse(num, out int numInt);
    while (realNum == false)
    {
        Console.WriteLine("Это не число!");
        Console.Write(message);
        num = Console.ReadLine()!;
        realNum = int.TryParse(num, out numInt);
    }
    return numInt;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки 
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] array)
{
    int sum = 0;
    int ind = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumTemp += array[i, j];
        }
        if (sumTemp < sum)
        {
            sum = sumTemp;
            ind = i;
        }
    }

    Console.WriteLine($"Минимальная суммма элементов в строке {ind + 1}");


}

int row = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int min = Prompt("Введите минимальное возможное значение в массиве: ");
int max = Prompt("Введите максимальное возможное значение в массиве: ");
int[,] arr = GetArray(row, col, min, max);
PrintArray(arr);
Console.WriteLine();
MinSumRow(arr);
