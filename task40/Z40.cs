// Задача 40: Напишите программу, которая принимает на вход три
//  числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.
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

int a = Prompt("Введите первое значение: ");
int b = Prompt("Введите второго значение: ");
int c = Prompt("Введите третье значение: ");

if (a<(b+c) && b<(a+c) && c<(a+b))
{
    Console.WriteLine("Треугольник с такими сторонами монжно задать.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами Нельзя задать.");    
}