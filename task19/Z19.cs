int Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine()!;
    if ((int.TryParse(num, out int numInt)) == false)
    {
        Console.WriteLine("Это не число!");
    }
    return numInt;
}

void Palindrome(int num)
{
    if (num < 10000)
    {
        Console.WriteLine("Число не пятизначное!");
    }
    else
    {
        int firstDigit = num / 10000;
        int secondDigit = num / 1000 % 10;
        int fourthDigit = num / 10 % 10;
        int lastDigit = num % 10;    
        if (firstDigit == lastDigit && secondDigit == fourthDigit)
        {
            Console.WriteLine("Число палиндром");
        }

        else
        {
        Console.WriteLine("Число не палиндром");
        }
    }
}
int number = Prompt("Введите пятизначное число: ");
Palindrome(number);