using System;

public static class StringExtensions
{
    public static int CountSentences(this string line)
    {
        int count = 0;
        foreach (char c in line)
        {
            if (c == '.' || c == '!' || c == '?')
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
        string text = "This is a sentence. And this is another! Finally, a third?";

        Console.WriteLine($"Number of sentences in \"{text}\": {text.CountSentences()}");
    }
}
