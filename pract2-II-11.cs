using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите число А = ");
        int a = int.Parse(Console.ReadLine());
        int k = 0;
        while (a > 0)
        {
            k += 1;
            a /= 10;
        }
        if (k != 3)
        {
            Console.WriteLine("Данное число не является трёхзначным.");
        }
        else
        {
            int x1 = a / 100;
            int x2 = a % 100 / 10;
            int x3 = a % 10;
            string s = (x1 != x2 & x2 != x3 & x1 != x3) ? "Разные" : "Не разные";
            Console.WriteLine(s);
        }
    }
}