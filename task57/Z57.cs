// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// -----------
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
            matrix[i,j] = new Random().Next(from,to);   //[from,to)
        }
    }
    return matrix;
}

void PrintMassive(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
}

int[] LineMatrix(int[,] matrix)
{
    int[] array = new int [matrix.GetLength(0)*matrix.GetLength(1)];
    int k = 0;
    for (int i = 0 ; i < matrix.GetLength(0) ;i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            array[k]=matrix[i,j];
            k++;
        }
    }
    return array;
}

void SelectionSortMin(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temparr = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temparr;
    }
}

void SelectionSortMax(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temparr = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temparr;
    }
}

void CountArray(int[] array)
{
    int count = 1;
    int temp = array[0];
    for (int i=1;i<array.Length;i++)
    {
        if (array[i]==temp)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Колличество элемента {temp} в массиве равно {count}");
            temp = array[i];
            count = 1;
        }
    }

            Console.WriteLine($"Колличество элемента {array[array.Length-1]} в массиве равно {count}");
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
int[] array = LineMatrix(matrix);
PrintMassive(array);

Console.WriteLine();
SelectionSortMax(array);
Console.WriteLine();
PrintMassive(array);
Console.WriteLine();

CountArray(array);