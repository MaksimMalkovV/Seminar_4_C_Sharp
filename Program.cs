// метод ввода значений.
int Entering_values(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = Entering_values("Введите число А: ");
int numberB = Entering_values("введите число В: ");
// int numberA = Convert.ToInt32(Console.ReadLine()!);
// int numberB = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"{numberA}, {numberB} ->> {GetDegree(numberA , numberB)}");
int GetDegree(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    return result;
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = Entering_values("Add number: ");
int len = NumsLen(number);
sumnumbers(number, len);
int NumsLen( int nums)
{
    int res = 0;
    while (nums > 0)
    {
        nums /= 10;
        res++;
    }
    return res;
}
void sumnumbers( int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
         sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр равна ->> {sum}");
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = FillArray(8);
Console.WriteLine($"{String.Join(",", arr)} - >>[{String.Join(",", arr)}]");

int[] FillArray( int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {       
        result[i] = new Random().Next(0,100);
    }
    return result;
}
