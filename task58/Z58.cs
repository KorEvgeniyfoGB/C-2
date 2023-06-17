// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array1.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                for (int z = 0; z < array1.GetLength(1); z++)
                {
                    multiArray[i, j] += array1[i, z] + array2[z, j];
                }
            }

        }
    }
    else
    {
        Console.WriteLine("Перемножение матриц невозможно!");
    }
    return multiArray;
}


int rowA = Prompt("Введите количество строк: ");
int colA = Prompt("Введите количество столбцов: ");
int rowB = Prompt("Введите количество строк: ");
int colB = Prompt("Введите количество столбцов: ");
int min = Prompt("Введите минимальное возможное значение в массиве: ");
int max = Prompt("Введите максимальное возможное значение в массиве: ");
int[,] arrA = GetArray(rowA, colA, min, max);
int[,] arrB = GetArray(rowB, colB, min, max);
PrintArray(arrA);
Console.WriteLine();
PrintArray(arrB);
Console.WriteLine();
PrintArray(MultiplicationMatrix(arrA, arrB));