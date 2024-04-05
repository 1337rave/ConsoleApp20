using System;
using System.Linq;

public class StudentGrades
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public StudentGrades(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public int GetMaxGrade()
    {
        return Grades.Max();
    }

    public double GetAverageGrade()
    {
        return Grades.Average();
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentGrades[] students = new StudentGrades[]
        {
            new StudentGrades("Alice", new int[] { 80, 90, 85 }),
            new StudentGrades("Bob", new int[] { 70, 75, 72 }),
            new StudentGrades("Charlie", new int[] { 85, 88, 90 })
        };

        // Find the student with the maximum grade
        StudentGrades studentWithMaxGrade = students.OrderByDescending(s => s.GetMaxGrade()).First();
        Console.WriteLine($"Student with maximum grade: {studentWithMaxGrade.Name}, Grade: {studentWithMaxGrade.GetMaxGrade()}");

        // Calculate the average grade of all students
        double averageGradeOfAllStudents = students.SelectMany(s => s.Grades).Average();
        Console.WriteLine($"Average grade of all students: {averageGradeOfAllStudents}");
    }
}
