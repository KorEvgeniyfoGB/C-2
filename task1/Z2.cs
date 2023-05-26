int max = 0;
int min = 0;
Console.WriteLine("Ввдетие число 1:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввдетие число 2:");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine("Максимальное: " + max +  " Минимальное: " + min);