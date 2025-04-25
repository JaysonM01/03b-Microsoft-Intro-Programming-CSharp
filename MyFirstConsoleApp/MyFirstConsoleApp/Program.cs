using System;
public class Program
{
// Method to calculate the average of an array
public static double CalculateAverage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}

public static void Main()
{
    int[] numbers = {}; // Empty array
    double average = CalculateAverage(numbers);
    Console.WriteLine("The average is: " + average);
}
}