using System;

public static class IntExtensions
{
    public static bool IsPrime(this int number)
    {
        if (number <= 1)
            return false;

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        int divisor = 5;
        int limit = (int)Math.Sqrt(number);

        while (divisor <= limit)
        {
            if (number % divisor == 0 || number % (divisor + 2) == 0)
                return false;

            divisor += 6;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 7;
        int num2 = 10;

        Console.WriteLine($"{num1} is prime: {num1.IsPrime()}");
        Console.WriteLine($"{num2} is prime: {num2.IsPrime()}");
    }
}
