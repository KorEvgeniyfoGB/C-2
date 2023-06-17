// Задайте двумерный массив. Напишите программу, которая заменяет строки 
// на столбцы. В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя

Console.Clear();
Console.WriteLine();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($"{matrix [i , j]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int i = 0 ; i < matrix.GetLength(0) ;i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            matrix[i,j] = new Random().Next(from,to);
        }
    }
    return matrix;
}

void RotateMatrixMainDiagonal(int[,] matrix)
{
    if (matrix.GetLength(0)==matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < i; ++j)
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[j,i];
                    matrix[j,i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратна...");
    }
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начальное значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");

Console.WriteLine($"Вы ввели: {row} , {col} , {from} , {to}");
Console.WriteLine();
int[,] matrix = CreateMRandoMatrix(row,col,from,to);
PrintMatrix(matrix);

Console.WriteLine();
RotateMatrixMainDiagonal(matrix);
PrintMatrix(matrix);