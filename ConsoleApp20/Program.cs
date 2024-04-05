using System;

public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
}

public static class FractionExtensions
{
    public static double GetValue(this Fraction fraction)
    {
        return (double)fraction.Numerator / fraction.Denominator;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fraction[] fractions = new Fraction[]
        {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(2, 3)
        };

        double minValue = double.MaxValue;
        Fraction minFraction = null;
        double maxValue = double.MinValue;
        Fraction maxFraction = null;

        // Find minimum and maximum values of fractions
        foreach (var fraction in fractions)
        {
            double value = fraction.GetValue();
            if (value < minValue)
            {
                minValue = value;
                minFraction = fraction;
            }
            if (value > maxValue)
            {
                maxValue = value;
                maxFraction = fraction;
            }
        }

        Console.WriteLine($"Minimum Fraction: {minFraction.Numerator}/{minFraction.Denominator}, Value: {minValue}");
        Console.WriteLine($"Maximum Fraction: {maxFraction.Numerator}/{maxFraction.Denominator}, Value: {maxValue}");
    }
}
