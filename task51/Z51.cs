// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix (int[,] matrix)
{
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            Console.Write($"{matrix [row , colum]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            matrix[row,colum] = new Random().Next(from,to);
        }
    }
    return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateMRandoMatrix(row,col,from,to);
PrintMatrix(matr);
Summ(matr);

void Summ(int[,] matrix)
{
    int row=0;
    int col=0;
    int summ = 0;
    while (row < matrix.GetLength(0))
    {
        summ= summ+matr[row,col];
        row++;
        col++;
    }
    Console.WriteLine($"Сумма элементов главной диагонали равна: {summ}");
}

