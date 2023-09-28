/*Разработать рекурсивный метод, возвращающий значение:
1) для вычисления n-го члена следующей последовательности 𝑏1 = −10, 𝑏2 = 2, 𝑏𝑛+2 = |𝑏𝑛| − 6𝑏𝑛+1.*/

using System;
public class Program
{
    static int b(int n)
    {
        if (n == 1)
            return -10;
        else if (n == 2)
            return 2;
        else
        {
            int bnm1 = b(n - 1);
            int bnm2 = b(n - 2);
            return Math.Abs(bnm1) - 6 * bnm2;
        }

    }
    public static void Main()
    {
        Console.Write("Введите число n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(b(n));
    }
}
