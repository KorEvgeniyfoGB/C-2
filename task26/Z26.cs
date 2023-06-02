// Задача 26: Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

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


int CountDigit(int number)
{
int count = 0;
while (number != 0)
{
number = number / 10;
count++;
}
return count;
}

int numb = Prompt ("Введите число: ");
int dig = CountDigit(numb);
Console.WriteLine($"Колличество цифр в числе равно: {dig}");