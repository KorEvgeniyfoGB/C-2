// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

void RandomMassive(int val)
{
    // int [] array = new int [8];
    int[] array = new int[val];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2); // генератор [a,b)
        Console.Write(array[i] + " ");
    }
}


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
int value = Prompt("Введите число ");
RandomMassive(value);