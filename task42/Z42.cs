int Reader()
{
    Console.WriteLine("enter your number: ");
    if (int.TryParse(Console.ReadLine(), out int num) == false || num < 0)
    {
        num = -1;
        return num;
    }
    else
    {
        return num;
    }
}

int CountDifiner(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 2;
        count++;
    }
    return count;
}

int[] BinaryNumConverter(int num, int count)
{
    int[] binaryNum = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        int temp = num % 2;
        num /= 2;
        binaryNum[i] = temp;
    }
    return binaryNum;
}

void PrintBinary(int[] binary)
{
    for (int i = 0; i < binary.Length; i++)
    {
        Console.Write(binary[i]);
    }
}

int num = Reader();
switch (num)
{
    case -1:
        Console.WriteLine("invalid number format");
        break;
    default:
        int count = CountDifiner(num);
        PrintBinary(BinaryNumConverter(num, count));
        break;
}


// int Input()
// {
//     Console.Write("Введите: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int[] Solution(int num)
// {
//     int[] res = new int[] {};
//     int i = 0;
//     while (num > 0)
//     {   
//         Array.Resize(ref res, res.Length + 1);    
//         res[i] = num % 2;
//         num = num /2;
//         i++;    
//     }
//     return res;
// }
// int[] ReverseArray2(int[] inArray)
// {
//     int[] res = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         res[i] = inArray[inArray.Length - 1 - i];
//         Console.Write($"{res[i]}");
//     }
//     return res;
// }
// int num1 = Input();
// int[] newArray = Solution(num1);
// ReverseArray2(newArray);


// int InPutNum(string message) // ввод данных
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void Convert10To2(int num)
// {
//     int res = 0;
//     string showresult = string.Empty;
//     while (num > 0)
//     {
//         res = num % 2;
//         num /= 2;
//         showresult = res + showresult; // 0 + "пустое значени" // 0+0 // 0+00 // 1+000//
//     }
//     Console.WriteLine();
//     Console.WriteLine(showresult);

// }

// int a = InPutNum("Введите число");
// Convert10To2 (a);

// string res1=Convert.ToString(number,2);