// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, 
//  добавляя индексы каждого элемента.

void PrintArray1(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                Console.Write($"{matr[i, j, z]}({i}, {j}, {z}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray1(int[,,] matr)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = new Random().Next(1, 9);       //Проверка что число оригинальное
        while (Array.IndexOf(arr, temp) != -1)    
            {
                temp = new Random().Next(1, 9);  
            }
        arr[i] = temp;        
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
            
                matr[i, j, z] = arr[i * matr.GetLength(1) * matr.GetLength(2) + j * matr.GetLength(2) + z];
            }
        }
    }
}

int[,,] martix = new int[2, 2, 2];
// PrintArray1(martix);
FillArray1(martix);
Console.WriteLine();
PrintArray1(martix);