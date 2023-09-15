//13. найти старшую цифру
using System;
namespace aboba
{
    class Program
    {
        static void Main()
        {
            string N;
            Console.Write("Введите N: ");
            N = Console.ReadLine();
            Console.WriteLine($"Старшая цифра: {N[0]}");
        }
    }
}
