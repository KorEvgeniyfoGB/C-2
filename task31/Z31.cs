// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] FindSum(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;
    int[] res = new int[2];
    foreach (int el in arr)
    {
        if (el > 0)
        {
            positiveSum += el;
        }
        else
        {
            negativeSum += el;
        }
    }
    res[0] = positiveSum;
    res[1] = negativeSum;
    return res;

}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
int[] summ = FindSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел - {summ[0]}, сумма отрицательных чисел - {summ[1]}");