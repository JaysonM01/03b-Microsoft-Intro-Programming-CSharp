public class UserInput
{
    public static void GreetUser()
    {

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main()
    {
        GreetUser();
    }
}