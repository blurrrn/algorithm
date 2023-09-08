using System;
public class Program
{
    public static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        //Console.WriteLine("a = {0}", a);
        //Console.WriteLine("b = {0}", b);
        int s = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, s);
    }
}
