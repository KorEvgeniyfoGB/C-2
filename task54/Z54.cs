// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] SelectionSortMaxColums(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int z = j + 1; z < arr.GetLength(1); z++)
            {
                if (arr[i, z] > arr[i, maxPosition]) maxPosition = z;
            }
            int temparr = arr[i,j];
            arr[i,j] = arr[i, maxPosition];
            arr[i, maxPosition] = temparr;
        }

    }
    return arr;
}


int row = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int min = Prompt("Введите минимальное возможное значение в массиве: ");
int max = Prompt("Введите максимальное возможное значение в массиве: ");
int[,] arr = GetArray(row, col, min, max);
PrintArray(arr);
Console.WriteLine();
PrintArray(SelectionSortMaxColums(arr));
