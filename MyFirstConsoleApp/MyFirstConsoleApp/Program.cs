// Method to divide two numbers with error handling
using System;
public class Program
{
public static double DivideNumbers(double numerator, double denominator)
{
    if (denominator == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
        return double.NaN; // Return "Not a Number" to indicate an error
    }
    
    double result = numerator / denominator;
    return result;
}

public static void Main()
{
    // Attempt to divide 10 by 0
    double result = DivideNumbers(10, 0);
    Console.WriteLine("The result is: " + result);
}
}