// Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Работает только с квадратными матрицами и 
// матрицами где количство столбцов не больше количества строк

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

int[,] SpirArr(int row, int col)
{
    int[,] array = new int[row, col];
    int minRow = 0;
    int maxRow = array.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = array.GetLength(1) - 1;
    int var = 1;
    while (var <= array.GetLength(1) * array.GetLength(1))
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minRow, i] = var;
            var++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = var;
            var++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = var;
            var++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = var;
            var++;
        }
        minCol++;
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за строки 
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int a = Prompt("Введите количество строк в заполняемой матрице: ");
int b = Prompt("Введите количество столбцов в заполняемой матрице: ");
int[,] matr = SpirArr(a, b);
PrintArray(matr);
