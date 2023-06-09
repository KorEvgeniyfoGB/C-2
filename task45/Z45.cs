// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

Console.Clear ();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
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