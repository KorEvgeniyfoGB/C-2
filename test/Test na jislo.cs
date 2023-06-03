// int Prompt(string message)  //Проверка на число
// {
//     Console.Write(message);
//     string num = Console.ReadLine()!;
//     bool realNum = int.TryParse(num, out int numInt);
//     while (realNum == false)
//     {
//         Console.WriteLine("Это не число!");
//         Console.Write(message);
//         num = Console.ReadLine()!;
//         realNum = int.TryParse(num, out numInt);
//     }
//     return numInt;
// }
//int n = Prompt("Введите число: ");
//Console.WriteLine(n);

// int RealTime()
// {
//      return DateTime.Now.Minute;
// }
// int time = RealTime();
// Console.Write(time);

// void RandomMassive()
// {
//     // int [] array = new int [8];
//     int[] array = new int[8] ;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine()); // генератор [a,b)
        
//     }
//     Console.ReadLine();
// }
double[] MyMassive()
{
    int n = int.Parse(Console.ReadLine()!);
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива:");
        array[i] = double.Parse(Console.ReadLine()!);
    }
    return array;
}
Console.Write(MyMassive());

double[] MyMassive(int val)
{
    double[] array = new double[val];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива:");
        array[i] = new Random().Next(10, 1000) / 100.0;
    }
    
    return array;
}

double[] MyMassive(int val)
{
    double[] array = new double[val];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива:");
        array[i] = double.Parse(Console.ReadLine()!);
    }
    
    return array;
}