public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("b = {0}", c);
        int s = a + b + c;
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, s);
    }
}
