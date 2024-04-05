using System;

public class DaytimeTemperature
{
    public double HighestTemperature { get; set; }
    public double LowestTemperature { get; set; }

    public DaytimeTemperature(double highestTemp, double lowestTemp)
    {
        HighestTemperature = highestTemp;
        LowestTemperature = lowestTemp;
    }

    public double TemperatureDifference()
    {
        return HighestTemperature - LowestTemperature;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Sample array of DaytimeTemperature objects
        DaytimeTemperature[] temperatures = new DaytimeTemperature[]
        {
            new DaytimeTemperature(30, 20), // Day 1
            new DaytimeTemperature(25, 15), // Day 2
            new DaytimeTemperature(35, 25), // Day 3
            new DaytimeTemperature(28, 18)  // Day 4
        };

        double maxDifference = double.MinValue;
        int[] daysWithMaxDifference = new int[0];

        // Calculate the maximum difference and corresponding days
        for (int i = 0; i < temperatures.Length; i++)
        {
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                double difference = Math.Abs(temperatures[i].TemperatureDifference() - temperatures[j].TemperatureDifference());
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    daysWithMaxDifference = new int[] { i + 1, j + 1 };
                }
                else if (difference == maxDifference)
                {
                    // If there's more than one pair of days with the maximum difference, add them to the array
                    Array.Resize(ref daysWithMaxDifference, daysWithMaxDifference.Length + 2);
                    daysWithMaxDifference[daysWithMaxDifference.Length - 2] = i + 1;
                    daysWithMaxDifference[daysWithMaxDifference.Length - 1] = j + 1;
                }
            }
        }

        Console.WriteLine($"Maximum difference between highest and lowest temperatures: {maxDifference}");

        if (daysWithMaxDifference.Length > 0)
        {
            Console.WriteLine("Days with the maximum difference:");
            foreach (int day in daysWithMaxDifference)
            {
                Console.WriteLine($"Day {day}");
            }
        }
        else
        {
            Console.WriteLine("No days found with the maximum difference.");
        }
    }
}
