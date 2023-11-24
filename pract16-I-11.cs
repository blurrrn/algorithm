using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = "numbers.txt";
            List<int> Numbers = new List<int>();
            string FileContent = File.ReadAllText(pathInput);
            string[] string_numbers = FileContent.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in string_numbers)
            {
                Numbers.Add(int.Parse(number));
            }
            var SortedNumbers = Numbers.Where(n => (n >= 10 && n <= 99)).Select(n => -n);
            string path_output = "output.txt";
            using (StreamWriter fout = new StreamWriter(path_output, false))
            {
                foreach (var n in SortedNumbers)
                    fout.Write($"{n} ");
            }
        }
    }
}
