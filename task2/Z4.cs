int max = 0;

Console.WriteLine("Ввдетие число 1:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввдетие число 2:");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввдетие число 3:");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
{
    max = number1;
}
else if(number2 > number1 && number2 > number3)
{
    max = number2;
    
}
else if(number3 > number1 && number3 > number2)
{
    max = number3;
    
}
Console.WriteLine("Максимальное: " + max);