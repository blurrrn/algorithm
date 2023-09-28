/*1.Разработать рекурсивный метод, который по заданному натуральному числу N (N1000) выведет на
экран все натуральные числа, не превышающие N, в порядке возрастания. Например, для N=8, на
экран выводится 1 2 3 4 5 6 7 8.*/

using System;

class Program
{
    static void f(int n)
    {
        if (n > 0)
        {
            f(n - 1);
            Console.Write($"{n} ");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число n = ");
        int n = int.Parse(Console.ReadLine());
        f(n);
    }
}
