using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод размерности массива
        Console.Write("Введите размерность ступенчатого массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание и заполнение ступенчатого массива
        int[][] array = new int[n][];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            array[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Поиск строки с первым минимальным элементом
        int minElement = int.MaxValue;
        int minElementRow = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (array[i][j] < minElement)
                {
                    minElement = array[i][j];
                    minElementRow = i;
                    break;
                }
            }
            if (minElementRow != -1)
            {
                break;
            }
        }

        // Вставка новой строки после строки с первым минимальным элементом
        int[][] newArray = new int[n + 1][];
        for (int i = 0; i <= minElementRow; i++)
        {
            newArray[i] = array[i];
        }
        newArray[minElementRow + 1] = new int[minElementRow + 2];
        for (int i = minElementRow + 2; i <= n; i++)
        {
            newArray[i] = array[i - 1];
        }

        // Ввод элементов новой строки
        Console.WriteLine("Введите элементы новой строки:");
        for (int i = 0; i < minElementRow + 2; i++)
        {
            newArray[minElementRow + 1][i] = int.Parse(Console.ReadLine());
        }

        // Вывод результата
        Console.WriteLine("Ступенчатый массив после вставки новой строки:");
        for (int i = 0; i < n + 1; i++)
        {
            for (int j = 0; j < newArray[i].Length; j++)
            {
                Console.Write(newArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
