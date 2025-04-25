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

public class Program
{
    public static void Main()
    {
        Animal Pitbull = new Dog();
        Animal Persian = new Cat();
        Pitbull.MakeSound();
        Persian.MakeSound();
        
    }
}