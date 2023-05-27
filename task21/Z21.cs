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

void CalcDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    Console.WriteLine("Расстояние между точками: " + string.Format("{0:f2}", d));
}

int x1 = Prompt("Введите координату X точки A: ");
int y1 = Prompt("Введите координату Y точки A: ");
int z1 = Prompt("Введите координату Z точки A: ");

int x2 = Prompt("Введите координату X точки B: ");
int y2 = Prompt("Введите координату Y точки B: ");
int z2 = Prompt("Введите координату Z точки A: ");

CalcDist(x1, y1,z1, x2, y2, z2);