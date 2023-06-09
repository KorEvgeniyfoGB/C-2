// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// апример, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
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

void GetElemArray(int[,] array)
{
    int row = Prompt("Введите первый индекс: ");
    int col = Prompt("Введите второй индекс: ");
    if (row > array.GetLength(0) || col > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Нужный элемент {array[row, col]}");
    }
}

int row = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int min = Prompt("Введите минимальное возможное значение в массиве: ");
int max = Prompt("Введите максимальное возможное значение в массиве: ");
int[,] arr = GetArray(row, col, min, max);
PrintArray(arr);
GetElemArray(arr);