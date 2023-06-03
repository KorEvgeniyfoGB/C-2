// Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

void NumberInArr(int[] arr, int number)
{
    string a = "НЕТ";
    foreach (int i in arr)
    {
        if (i == number)
        {
            a = "ДА";
            break;
        }
        
    }
    Console.WriteLine(a);
    ;
}
int size = Prompt("Введите размер массива: ");
int min = Prompt("Введите минимальное значение диапазона: ");
int max = Prompt("Введите максимальное значение диапазона: ");
int[] array = GetArray(size, min, max);
PrintArray(array);
Console.WriteLine();
int num = Prompt("Введите искомое число: ");
NumberInArr(array, num);