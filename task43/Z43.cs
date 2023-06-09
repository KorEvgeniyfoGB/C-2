// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//k1 * x + b1 = k2 * x + b2
//x = b2 - b1 / k1 - k2

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

void PointIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 - k2 == 0)
    {
        Console.WriteLine("Функции не имеют точек пересечения");
    }
    else if (b2 - b1 == 0)
    {
        Console.WriteLine("Функции идентичны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Функции пересекаются в точке ({x}, {y})");
    }
}

double b1 = Prompt("Введите точку b1: ");
double k1 = Prompt("Введите точку к1: ");
double b2 = Prompt("Введите точку b2: ");
double k2 = Prompt("Введите точку к2: ");
PointIntersection(b1, k1, b2, k2);

