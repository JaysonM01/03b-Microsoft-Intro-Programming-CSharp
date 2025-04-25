public class Calculator
{
    public int num1;
    public int num2;

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Main()
    {
        Console.WriteLine(Add(10,20));
        
    }
}