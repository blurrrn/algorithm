//11) все нечетные числа из диапазона от А до В, кратные пяти
class Program
{
    static void Main()
    {
        int A, B;
        Console.Write("Введите A: ");
        A =int.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        B = int.Parse(Console.ReadLine());
        while (A % 5 != 0)
        {
            A++;
        }
        for (int x = A; x <= B; x+=5)
        {
            Console.WriteLine("{0} ",x);
        }
    }
}
