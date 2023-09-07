public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите процент по вкладу:");
        double b = double.Parse(Console.ReadLine());
        double m = a / 100 * b;
        Console.WriteLine("Через год начислят: {0:c}", m);
    }
}
