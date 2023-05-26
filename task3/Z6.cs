string even = "";
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    even = "Да";
}
else
{
    even = "Нет";
}
Console.WriteLine(even);