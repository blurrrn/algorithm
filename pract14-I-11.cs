using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;
class Program
{
    struct Spoint
    {
        public double x, y;
        public Spoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Spoint(List<double> Coords)
        {
            this.x = Coords[0];
            this.y = Coords[1];
        }

        public string PrintPoint()
        {
            return ($"({this.x}, {this.y})\n");
        }
    }
    static List<double> GetCoords(string line)
    {
        string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<double> ans = new List<double>();
        for (int i = 0; i < 2; i++)
        {
            ans.Add(Convert.ToDouble(numbers[i]));
        }
        return ans;
    }
    static bool InCircle(Spoint point, Spoint centre, double R)
    {
        if ((point.x - centre.x) * (point.x - centre.x) + (point.y - centre.y) * (point.y - centre.y) <= R * R)
        {
            return true;
        }
        return false;
    }
    struct PointCountsPair
    {
        public Spoint centre;
        public int count;
        public PointCountsPair(Spoint centre, int count)
        {
            this.centre = centre;
            this.count = count;
        }
        public void PrintCoords()
        {
            Console.WriteLine($"({this.centre.x}, {this.centre.y}), вокруг {this.count} точек");
        }
    }
    static void Main()
    {
        string inputFile = "input1z.txt";
        string outputFile = "output1z.txt";
        using (StreamReader reader = new StreamReader(inputFile))
        {
            using (StreamWriter writer = new StreamWriter(outputFile, false))
            {
                string line;
                int PointsCount = 0;
                double R = Convert.ToDouble(reader.ReadLine());
                Stack<PointCountsPair> pcp = new Stack<PointCountsPair>();
                List<Spoint> points = new List<Spoint>();
                while ((line = reader.ReadLine()) != null)
                {
                    points.Add(new Spoint(GetCoords(line)));
                }
                for (int i = 0; i < points.Count; i++)
                {
                    PointsCount = 0;
                    Spoint Centre = points[i];
                    for (int j = 0; j < points.Count; j++)
                    {
                        if (i != j)
                        {
                            if (InCircle(points[j], Centre, R))
                            {
                                PointsCount++;
                            }
                        }
                    }
                    if (pcp.Count > 0)
                    {
                        if (PointsCount < pcp.Peek().count)
                        {
                            pcp.Clear();
                            pcp.Push(new PointCountsPair(Centre, PointsCount));
                        }
                        else if (PointsCount == pcp.Peek().count)
                        {
                            pcp.Push(new PointCountsPair(Centre, PointsCount));
                        }
                    }
                    else
                    {
                        pcp.Push(new PointCountsPair(Centre, PointsCount));
                    }
                }
                if (pcp.Count > 0)
                {
                    Console.WriteLine($"Радиус: {R}");
                    int c = 1;
                    foreach (var p in pcp)
                    {
                        Console.WriteLine($"Окружность #{c}");
                        p.PrintCoords();
                        c++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Точки не найдены");
                }
            }

        }

    }
}
