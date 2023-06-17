// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Clear();

// int Prompt (string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     int val = 0;
//     while ((int.TryParse(value, out val)) != true)
//     {
//         Console.Write("Неверный ввод. Повторите: ");
//         value = Console.ReadLine();
//     }
//     Console.Clear();
//     return val;
// }

// int number = Prompt("Введиче число: ");
// int i = 1;


// void NaturalNumber(int number,int count)
// {    
//     if (count<=number)
//     {
//         Console.Write($"{count} ");
//         NaturalNumber(number,count+1);
//     }
// }

// NaturalNumber(number,i);


Console.Clear();

int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumber(number));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string PrintNumber(int number)
{
    if (number == 1) return "1";

    return $"{PrintNumber(number - 1)} {number}";
}