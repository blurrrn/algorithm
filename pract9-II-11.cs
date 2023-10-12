using System;
using System.IO;

class Program
{
    static void Main()
    {
        string input = "f.txt";
        string outputD = "g.txt";
        string outputS = "h.txt";

        using (StreamReader reader = new StreamReader(input))
        {
            using (StreamWriter writerD = new StreamWriter(outputD))
            {
                using (StreamWriter writerS = new StreamWriter(outputS))
                {
                    while (!reader.EndOfStream)
                    {
                        char c = (char)reader.Read();
                        if (Char.IsDigit(c))
                        {
                            writerD.Write(c);
                        }
                        else
                        {
                            writerS.Write(c);
                        }
                    }
                }
            }
        }

        Console.WriteLine("Цифры из файла f записаны в файл g.");
        Console.WriteLine("Остальные символы из файла f записаны в файл h.");
    }
}
