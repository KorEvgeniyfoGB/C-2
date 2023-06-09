// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear ();

Console.Clear ();

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

int n = Prompt("Введите количество элементов: ");
int num1 = 0;
int num2 = 1;
int num = 0;
Console.Write($"{0}, {1}");
for(int i=3;i<=n;i++)
{
    num=num1+num2;
    num1= num2;
    num2=num;
    Console.Write($", {num}");
}