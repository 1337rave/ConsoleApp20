using System;

public static class StringExtensions
{
    public static int LengthOfLastWord(this string str)
    {
        // Split the string by whitespace characters and remove any empty entries
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Check if there are any words in the string
        if (words.Length == 0)
            return 0;

        // Get the last word from the array
        string lastWord = words[words.Length - 1];

        // Return the length of the last word
        return lastWord.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text = "This is a sample sentence with 7 words.";

        Console.WriteLine($"Length of the last word in the text: {text.LengthOfLastWord()}");
    }
}
