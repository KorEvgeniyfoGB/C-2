//Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void FindThirdDigit(int num)
{
int thirdD = num / 100;

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int realthirdD = thirdD % 10;
    Console.WriteLine("Третья цифра: " + realthirdD);
}
}

Console.WriteLine("Введите любое число:");
int number = int.Parse(Console.ReadLine()!);
FindThirdDigit(number);