using System;

public struct SPoint
{
    public double X;
    public double Y;

    public SPoint(double x, double y)
    {
        X = x;
        Y = y;
    }
}

public static class KRUG
{
    public static SPoint FindCenter(SPoint[] points, double R)
    {
        int minPoints = 9999;
        SPoint minPoint = new SPoint();

        // Перебираем все точки
        for (int i = 0; i < points.Length; i++)
        {
            int pointsInCircle = 0;

            // Подсчитываем количество точек, входящих в окружность с центром в текущей точке
            for (int j = 0; j < points.Length; j++)
            {
                if (i == j)
                    continue;

                double distance = Math.Sqrt(Math.Pow(points[i].X - points[j].X, 2) + Math.Pow(points[i].Y - points[j].Y, 2));
                if (distance <= R)
                    pointsInCircle++;
            }

            // Если текущая точка имеет меньшее количество точек в окружности, обновляем минимальное значение
            if (pointsInCircle < minPoints)
            {
                minPoints = pointsInCircle;
                minPoint = points[i];
            }
        }

        return minPoint;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SPoint[] points = new SPoint[]
        {
            new SPoint(1, 1),
            new SPoint(2, 3),
            new SPoint(4, 2),
            new SPoint(5, 6),
            new SPoint(7, 1)
        };

        double R = 3;

        SPoint minPoint = KRUG.FindCenter(points, R);

        Console.WriteLine($"Центр окружности с минимальным числом точек: ({minPoint.X}, {minPoint.Y})");
    }
}
