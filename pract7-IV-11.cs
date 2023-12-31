/*Для каждой строки найти последний четный элемент и записать данные в новый массив.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк и столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] A = new int[n, n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(String.Format("{0,3}", A[i, j]));
            Console.WriteLine();
        }

        int[] B = new int[n];

        for (int i = 0; i < n; i++)
        {
            B[i] = -1;
            for (int j = n-1; j >= 0; j--)
            {
                if (A[i, j] % 2 == 0)
                {
                    B[i] = A[i, j];
                    break;
                }
            }
            //B[i] = even;
        }

        Console.WriteLine("Последние четные элементы в каждой строке:");
        for (int i = 0; i < n; i++)
        {
            if (B[i] != -1)
            {
                Console.Write($"{B[i]} ");
            }
            //Console.Write($"{B[i]} ");
        }
    }
}
