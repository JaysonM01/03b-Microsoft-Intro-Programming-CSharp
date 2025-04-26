public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine("Hello! My name is " + Name + ".");
    }
    
    public static void Main()
    {
        Person Man = new Person();
        Man.Name = "Adam";
        Man.Age = 25;
        Person Woman = new Person();
        Woman.Name = "Eve";
        Woman.Age = 24;
        Person Child = new Person();
        Child.Name = "Alice";
        Child.Age = 12;

        Man.Greet();
        Woman.Greet();
        Child.Greet();
    }

}
