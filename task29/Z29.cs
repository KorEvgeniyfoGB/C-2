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

void MyMassive(int val, int min, int max)
{
    // int [] array = new int [8];
    int[] array = new int[val];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max); // генератор [a,b)
        Console.Write(array[i] + " ");
    }
}

int value = Prompt("Введите количество элементов массива: ");
int minimum = Prompt("Введите минимальное число диапазона чисел в масссиве ");
int maximum = Prompt("Введите минимальное число диапазона чисел в масссиве ");
MyMassive(value, minimum, maximum);