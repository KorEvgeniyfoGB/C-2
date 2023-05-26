void WeekEnd(int num)
{
if (num > 7 && num < 1 )
{
    Console.WriteLine("Нет такого дня в человеческой недели");
}
else if (num > 5)
{
    Console.WriteLine("Выходной!!УРААА");
}
else
{
    Console.WriteLine("Будни, паши дальше");
}
}
Console.WriteLine("Введите любое число:");
int number = int.Parse(Console.ReadLine()!);
WeekEnd(number);