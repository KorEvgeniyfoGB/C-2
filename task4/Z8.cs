Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int res = 2;

while (res <= num)
{
    Console.Write(res + " ");
    res += 2;  
}
