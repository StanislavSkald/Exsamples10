//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int N = Convert.ToInt32 (Console.ReadLine());
int count = 1;
GetNumber (N, count);


void GetNumber (int n, int x)
{
    if (x > n) return;
    GetNumber (n, x+1);
    Console.Write(x + " ");
}