// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите неотрицательное число M");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N");
int N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(Akkerman(M,N));

int Akkerman (int m, int n)
{
    if (m == 0) 
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else
    {
    return Akkerman(m-1, Akkerman(m, n - 1));
    }
}