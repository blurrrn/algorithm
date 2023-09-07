public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите номинал купюры:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во купюр:");
        int b = int.Parse(Console.ReadLine());
        int m = a * b;
        Console.WriteLine("Сумма денег: {0:c}", m);
    }
}
