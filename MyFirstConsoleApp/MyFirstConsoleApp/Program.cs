// Target interface
public interface ITarget
{
    void Request();
}

// Adaptee class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request is called.");
    }
}

// Adapter class
public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // Convert the interface of Adaptee to the Target interface
        adaptee.SpecificRequest();
    }
}

public class Program
{
    public static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        target.Request(); // Outputs: Specific request is called.
    }
}