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


int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}
int value = Prompt("Введите число ");
RandomMassive(value);