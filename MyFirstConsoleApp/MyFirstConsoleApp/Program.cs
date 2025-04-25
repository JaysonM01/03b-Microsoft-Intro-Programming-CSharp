// Method to divide two numbers
using System;
public class Program
{
public static int DivideNumbers(int numerator, int denominator)
{
    int result = numerator / denominator;
    return result;
}

public static void Main()
{
    // Attempt to divide 10 by 0
    int result = DivideNumbers(10, 0);
    Console.WriteLine("The result is: " + result);
}
}