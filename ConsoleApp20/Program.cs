using System;

public static class IntExtensions
{
    public static bool IsFibonacci(this int number)
    {
        if (number <= 1)
            return true; // 0 and 1 are considered Fibonacci numbers

        int a = 0, b = 1;
        while (b < number)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == number;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 8;
        int num3 = 9;

        Console.WriteLine($"{num1} is Fibonacci: {num1.IsFibonacci()}");
        Console.WriteLine($"{num2} is Fibonacci: {num2.IsFibonacci()}");
        Console.WriteLine($"{num3} is Fibonacci: {num3.IsFibonacci()}");
    }
}
