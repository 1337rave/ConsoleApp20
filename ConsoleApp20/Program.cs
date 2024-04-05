using System;

public static class StringExtensions
{
    public static int CountVowels(this string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text = "Hello, World!";

        Console.WriteLine($"Number of vowels in \"{text}\": {text.CountVowels()}");
    }
}
