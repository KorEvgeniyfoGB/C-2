// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}



int SumNaturalNumber (int number1,int number2)
{
    int summ = number1;
    if (number1<number2)
    {
        summ = number1 + (SumNaturalNumber(number1+1,number2));
    }
    return summ; 
}


int number1 = Prompt("Введите 1 число: ");
int number2 = Prompt("Введите 2 число: ");

if (number1>number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
Console.WriteLine(SumNaturalNumber(number1,number2));