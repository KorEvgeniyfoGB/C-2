// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

Console.Clear ();

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

int[] CreateRandomMassive(int val)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);  // генератор [a,b)
        // Console.Write (array[i]+" ");
    }
    return array;
}

void PrintMassive(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine ();
}

int val = Prompt("Введите количество элементов массива: ");
int[] origin = CreateRandomMassive(val);

int[] copy = new int[val];
for (int i=0; i<val; i++)
{
    copy [i] = origin [i];
}

PrintMassive(origin);
Console.WriteLine ("----------- ");
PrintMassive(copy);