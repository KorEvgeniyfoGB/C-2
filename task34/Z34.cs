// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
//  количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] RandomMassive(int val)
{
    // int [] array = new int [8];
    int[] array = new int[val];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); // положительные трехзначные числа
        Console.Write(array[i] + " "); //видим массив без отдельного метода
    }
    return array;
}
int evenNumInArray(int[] array) //метод для нахождения количества чётных чисел
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}
int Prompt(string message)  //С проверкой на число
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
int val = Prompt("Введите размер массива: ");
int evNum = evenNumInArray(RandomMassive(val));
Console.WriteLine(" ");
Console.WriteLine($"Количество положительных чисел в массиве: {evNum}");