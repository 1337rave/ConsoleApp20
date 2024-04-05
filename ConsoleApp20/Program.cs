using System;

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 6;
        int num2 = 11;

        Console.WriteLine($"{num1} is even: {num1.IsEven()}");
        Console.WriteLine($"{num2} is even: {num2.IsEven()}");
    }
}
