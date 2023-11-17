using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
class Structures
{
    // Создаем структуру Tovar
    public struct Tovar
    {
        // Поля структуры
        public string ProdType;
        public string Price;
        public string Variety;
        public int Amount;
        // Конструктор, принимающий входные данные через запятую
        public Tovar(string prodType, string price, string variety, int amount, string address, string school)
        {
            ProdType = prodType;
            Price = price;
            Variety = variety;
            Amount = amount;
        }

        // Конструктор, принимающий одну строковую переменную line
        public Tovar(string line)
        {
            string[] data = line.Split(' ');
            ProdType = data[0];
            Price = data[1];
            Variety = data[2];
            Amount = int.Parse(data[3]);
        }
        public string GetTovarData()
        {
            return $"{this.ProdType} {this.Price} {this.Variety} {this.Amount}";
        }
        static void Main()
        {
            string input_path = "input.txt";
            string output_path = "output.txt";
            using (StreamReader reader = new StreamReader(input_path))
            {
                using (StreamWriter writer = new StreamWriter(output_path, false))
                {
                    List<Tovar> TovarList = new List<Tovar>();
                    string line;
                    Console.Write("Введите Amount: ");
                    int k = int.Parse(Console.ReadLine());
                    while ((line = reader.ReadLine()) != null)
                    {
                        TovarList.Add(new Tovar(line));
                    }
                    //var sortedTov =
                    //    from Amount in TovarList
                    //    orderby Amount < k
                    //    select n;
                    foreach (Tovar student in TovarList)
                    {
                        if (student.School == school)
                            writer.WriteLine(student.GetTovarData());
                    }
                }
            }
        }
    }
}
