//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
void FindSecondDigit(int num)
{
int secondD = num / 10 % 10;
Console.WriteLine("Вторая цифра: " + secondD);
}

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);
FindSecondDigit(number);