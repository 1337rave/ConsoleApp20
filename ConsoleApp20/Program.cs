using System;

public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double DistanceTo(Point3D other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        double dz = Z - other.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point3D[] points = new Point3D[]
        {
            new Point3D(1, 2, 3),
            new Point3D(4, 5, 6),
            new Point3D(-2, 0, 8)
        };

        double maxDistance = 0;
        Point3D maxDistancePoint1 = null;
        Point3D maxDistancePoint2 = null;

        // Calculate distance between each pair of points
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                double distance = points[i].DistanceTo(points[j]);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    maxDistancePoint1 = points[i];
                    maxDistancePoint2 = points[j];
                }
            }
        }

        Console.WriteLine($"Maximum distance: {maxDistance}");
        Console.WriteLine($"Points with maximum distance:");
        Console.WriteLine($"Point 1: ({maxDistancePoint1.X}, {maxDistancePoint1.Y}, {maxDistancePoint1.Z})");
        Console.WriteLine($"Point 2: ({maxDistancePoint2.X}, {maxDistancePoint2.Y}, {maxDistancePoint2.Z})");
    }
}
