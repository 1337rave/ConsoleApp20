using System;

public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        // Split the string by whitespace characters
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        // Return the count of the words
        return words.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text = "This is a sample sentence with 7 words.";

        Console.WriteLine($"Number of words in the text: {text.WordCount()}");
    }
}
