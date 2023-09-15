//13. найти старшую цифру
using System;
class Program
{
    static void Main()
    {
        int ans = 0, N;
        Console.Write("Введите N: ");
        N = int.Parse(Console.ReadLine());
        while (N != 0)
        {
            ans = N;
            N /= 10;
        }
        Console.WriteLine($"Старшая цифра: {ans}");
    }
}
