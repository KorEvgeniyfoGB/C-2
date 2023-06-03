// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] MyMassive(int val, int min, int max)
{
    int[] array = new int[val];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max); // генератор [a,b)
        Console.Write(array[i] + " ");
    }
    return array;
}

int unevenSum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) //проходим сразу по нечетным
    {
        sum += array[i];
    }
    return sum;
}
int s = unevenSum(MyMassive(Prompt("Длина массиваж "), Prompt("Мин диапазон: "), Prompt("Макс диапазон: ")));
Console.WriteLine(" ");
Console.WriteLine($"Сумма элементов на нечётных индексах: {s}");
