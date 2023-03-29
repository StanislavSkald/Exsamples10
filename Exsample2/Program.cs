//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {GetSum(M,N)} ");


int GetSum (int m, int n)
{
    if (n == m) return n;
    return n += GetSum (m, n - 1);
}