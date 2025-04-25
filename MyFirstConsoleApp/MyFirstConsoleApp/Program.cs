public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some Sounds");
    }
    public void Eat()
    {
        Console.WriteLine("Some Food");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("*woof*");
    }
    public void Eat()
    {
        Console.WriteLine("Steak");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("*meow*");
    }
    public void Eat()
    {
        Console.WriteLine("Fish");
    }
}

public class Program
{
    public static void Main()
    {
        Dog Pitbull = new Dog();
        Cat Persian = new Cat();
        Pitbull.MakeSound();
        Persian.MakeSound();
        Pitbull.Eat();
        Persian.Eat();
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}

public interface IAnimal
{
    public void Eat();
    
}