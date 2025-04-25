public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some Sounds");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("*woof*");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("*meow*");
    }
}
