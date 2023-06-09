// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int colum = 0; colum < matrix.GetLength(1); colum++)
        {
            Console.Write($" {matrix[row, colum]}");
        }
        Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix(int rows, int colums, int from, int to)
{
    int[,] matrix = new int[rows, colums];
    to++;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int colum = 0; colum < matrix.GetLength(1); colum++)
        {
            matrix[row, colum] = new Random().Next(from, to);
        }
    }
    return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateMRandoMatrix(row, col, from, to);
PrintMatrix(matr);

int[,] Sqare(int[,] array)
{
    for (row = 0; row < matr.GetLength(0); row++)
    {
        for (col = 0; col < matr.GetLength(1); col++)
        {
            if (row % 2 == 0 && col % 2 == 0)
            {
                matr[row, col] = matr[row, col] * matr[row, col];
            }
        }
    }
    return array;
}

Console.WriteLine();
PrintMatrix(Sqare(matr));