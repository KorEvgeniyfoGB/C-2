//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] MirrorArray(int[] arr)
{
    int[] mirr = new int[arr.Length];
    for (int i = 0; i < mirr.Length; i++)
    {
         mirr[i] = - arr[i];
    }
    return mirr;
}
int size = Prompt("Введите размер массива: ");
int min = Prompt("Введите минимальное значение диапазона: ");
int max = Prompt("Введите максимальное значение диапазона: ");
int[] array = GetArray(size, min, max);
PrintArray(array);
int[] mirror = MirrorArray(array);
Console.WriteLine();
PrintArray(mirror);