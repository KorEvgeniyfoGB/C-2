// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


void NaturalNumber (int number1)
{
    if (number1 >= 1)
    {
        Console.Write($"{number1} ");
        NaturalNumber(number1 - 1);
    }
}


int number1 = Prompt("Введите число: ");
NaturalNumber(number1);