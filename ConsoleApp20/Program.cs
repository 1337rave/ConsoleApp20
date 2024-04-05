using System;

public static class IntExtensions
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} is odd: {num1.IsOdd()}");
        Console.WriteLine($"{num2} is odd: {num2.IsOdd()}");
    }
}
