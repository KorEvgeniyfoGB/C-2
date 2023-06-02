// Задача 28: Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Multipli(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}

int num = Prompt("Введите число: ");
Console.WriteLine($"Произведение всех чисел равно: {Multipli(num)}");