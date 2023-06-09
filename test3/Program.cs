﻿
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


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
        int temp = new Random().Next(1, 100);
        foreach (int item in arr)
        {
            if (item == temp)
            {
                temp = new Random().Next(1, 100);  
            }
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

int[,,] martix = new int[3, 3, 3];
// PrintArray1(martix);
FillArray1(martix);
Console.WriteLine();
PrintArray1(martix);