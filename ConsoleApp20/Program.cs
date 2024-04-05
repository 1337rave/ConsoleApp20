using System;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

public static class PersonExtensions
{
    public static double AverageAge(this Person[] people)
    {
        if (people.Length == 0)
            return 0;

        int totalAge = 0;
        foreach (var person in people)
        {
            totalAge += person.Age;
        }
        return (double)totalAge / people.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an array of Person objects
        Person[] people = new Person[]
        {
            new Person { Name = "John", Surname = "Doe", Age = 25 },
            new Person { Name = "Jane", Surname = "Smith", Age = 30 },
            new Person { Name = "Alice", Surname = "Johnson", Age = 20 }
        };

        // Find individuals with minimum and maximum ages
        var minAgePerson = people.OrderBy(p => p.Age).FirstOrDefault();
        var maxAgePerson = people.OrderByDescending(p => p.Age).FirstOrDefault();

        // Display their average age
        double averageAge = people.AverageAge();

        Console.WriteLine($"Person with minimum age: {minAgePerson.Name} {minAgePerson.Surname}, Age: {minAgePerson.Age}");
        Console.WriteLine($"Person with maximum age: {maxAgePerson.Name} {maxAgePerson.Surname}, Age: {maxAgePerson.Age}");
        Console.WriteLine($"Average age: {averageAge}");
    }
}
