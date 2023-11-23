//На основе данных входного файла составить инвентарную ведомость
//склада, включив следующие данные: вид продукции, стоимость, сорт, количество. Вывести в
//новый файл информацию о той продукции, количество которой менее заданной величины,
//отсортировав ее по количеству продукции на складе.
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
        public int Price;
        public string Variety;
        public int Amount;
        // Конструктор, принимающий входные данные через запятую
        public Tovar(string prodType, int price, string variety, int amount)
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
            Price = int.Parse(data[1]);
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
            //Console.WriteLine("Введите заданное количество: ");
            //Con
            using (StreamReader reader = new StreamReader(input_path))
            {
                using (StreamWriter writer = new StreamWriter(output_path, false))
                {
                    List<Tovar> TovarList = new List<Tovar>();
                    string line;
                    Console.Write("Введите заданное количество: ");
                    int k = int.Parse(Console.ReadLine());
                    while ((line = reader.ReadLine()) != null)
                    {
                        TovarList.Add(new Tovar(line));
                    }
                    var sortedTov1 = TovarList.Where(t => t.Amount < k);
                    var sortedTov2 = sortedTov1.OrderBy(t => t.Amount);
                    foreach (var t in sortedTov2)
                        writer.WriteLine(t.GetTovarData());

                }
            }
        }
    }
}
