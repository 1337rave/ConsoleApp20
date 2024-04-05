using System;
using System.Collections.Generic;

public static class StringExtensions
{
    public static bool IsValidParentheses(this string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in str)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                    return false; // There is no corresponding opening bracket for the current closing bracket

                char opening = stack.Pop();

                // Check if the closing bracket matches the last opening bracket
                if ((c == ')' && opening != '(') ||
                    (c == ']' && opening != '[') ||
                    (c == '}' && opening != '{'))
                {
                    return false;
                }
            }
        }

        // Check if there are any remaining opening brackets in the stack
        return stack.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] testStrings = {
            "{}[]",   // valid string
            "(())",   // valid string
            "[{}]",   // valid string
            "[}",     // invalid string
            "[[{]}]", // invalid string
        };

        foreach (string testString in testStrings)
        {
            Console.WriteLine($"String \"{testString}\" is valid: {testString.IsValidParentheses()}");
        }
    }
}
