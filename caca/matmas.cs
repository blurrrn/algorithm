// В массиве размером n×n, элементы которого – целые числа, произвести следующие
// действия:
// Замечание. Для хранения массив n×n использовать двумерный или ступенчатый массив. Свой выбор
// обосновать
// Вставить строку из нулей после всех строк, в которых нет ни одного нуля.
// // Дан массив размером n×n, элементы которого целые числа.
// // Замечание. Для хранения массив n×n использовать двумерный или ступенчатый массив. Свой выбор
// // обосновать.
// Для каждого столбца найти номер первой пары одинаковых элементов. Данные записать
// в новый массив.
/*using System.Security.Cryptography.X509Certificates;*/

class Program
{
    static bool NoZeroz(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void InputArray(out int[][] a, int n)
    {
        a = new int[n * 2][];
        for (int i = 0; i < n; i++) { a[i] = new int[n]; }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i][j] = Convert.ToInt32((Console.ReadLine()));
            }
        }
    }
    static void Print(int[][] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", a[i][j]);
            }
            Console.WriteLine();
        }
    }
    static void InputRaw(int[][] a, int[] item, int pos, int n)
    {
        for (int i = n; i > pos; i--)
        {
            a[i] = a[i - 1];
        }
        a[pos + 1] = item;
    }
    static void Main()
    {
        Console.Write($"Введите n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a;
        int[] zeros = new int[n];
        Console.Write("Вводите массив по строчкам \n");
        InputArray(out a, n);
        Print(a, n);
        for (int i = 0; i < n; i++)
        {
            if (NoZeroz(a[i]))
            {
                InputRaw(a, zeros, i, n);
                i++;
                n++;
            }
        }
        Console.WriteLine("---------------------");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write($"{a[i][j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------------");
    }
}
