// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] MyMassive(int val)
{
    double[] array = new double[val];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 10000) / 100.0;
    }
    
    return array;
}

double DifferenceMaxMinInArray(double[] array)
{
    double diff = array.Max() - array.Min();
    return diff;
}
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
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int size = Prompt("Введите размер массива: ");
double[] array = MyMassive(size);
PrintArray(array);
double difference = DifferenceMaxMinInArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Разность между максимальным и минимальным значением массива = {difference}");