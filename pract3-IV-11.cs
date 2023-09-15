//11) все нечетные числа из диапазона от А до В, кратные пяти
using System;
namespace aboba
{
    class Program
    {
        static void Main()
        {
            int A, B;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            while (A % 5 != 0)
            {
                A++;
            }
            Console.WriteLine("Числа, кратные 5 из диапазона [A,B]:");
            for (int x = A; x <= B; x += 5)
            {
                Console.Write("{0} ", x);
            }
        }
    }
}
