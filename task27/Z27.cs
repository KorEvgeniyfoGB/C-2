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

int SumDigits(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

int num = Prompt("Введите число: ");
int sum = SumDigits(num);
Console.WriteLine($"Сумма цифр введенного числа равна: {sum}");