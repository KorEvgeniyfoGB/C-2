// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int number1 = Prompt("Введите 1 число: ");
int number2 = Prompt("Введите 2 число: ");

if (number1>number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}

void NaturalNumber (int number1,int number2)
{
    if (number1<=number2)
    {
        Console.Write($"{number1} ");
        NaturalNumber(number1+1,number2);
    }
}

NaturalNumber(number1,number2);