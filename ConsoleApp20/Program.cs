using System;

public static class ArrayExtensions
{
    public static int[] Filter(this int[] array, Func<int, bool> predicate)
    {
        // Initialize a dynamic list to store filtered elements
        var filteredList = new System.Collections.Generic.List<int>();

        // Iterate through the array and apply the predicate to each element
        foreach (int element in array)
        {
            // If the predicate evaluates to true for the current element, add it to the filtered list
            if (predicate(element))
            {
                filteredList.Add(element);
            }
        }

        // Convert the list to an array and return
        return filteredList.ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Predicate for filtering even numbers
        Func<int, bool> isEven = n => n % 2 == 0;

        // Filter even numbers
        int[] evenNumbers = numbers.Filter(isEven);

        Console.WriteLine("Even numbers:");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Predicate for filtering odd numbers
        Func<int, bool> isOdd = n => n % 2 != 0;

        // Filter odd numbers
        int[] oddNumbers = numbers.Filter(isOdd);

        Console.WriteLine("Odd numbers:");
        foreach (int num in oddNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
