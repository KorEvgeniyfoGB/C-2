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

int ExponentA(int a, int b)
{
    int sq = a;
    while (b > 1)
    {
        sq *= a;
        b --; 
    }
    return sq;
}

int numA = Prompt("Ведие число А: ");
int numB = Prompt("Ведие число В: ");
int expA = ExponentA(numA, numB);
Console.WriteLine($"Число А в степени В равно: {expA}");
