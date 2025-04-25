public class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;
    public static void AddTask()
    {
        Console.WriteLine("What is your task?");
        for (int i = 0; i == taskCount; taskCount++)
        {
            tasks[i] = Console.ReadLine();
        }
    }
    public static void ViewTasks()
    {
        for (int i = 0; i + 1 <= taskCount; i++)
        {
            Console.WriteLine(i+1 + ". " + tasks[i]);
        }
    }
    public static void CompleteTask()
    {
        Console.WriteLine("Select a task you completed.");
        int taskSelect = (int.Parse(Console.ReadLine())) - 1;
        if (taskSelect >= taskCount)
        {
            Console.WriteLine("Selected task does not exist. Please try again.");
        }
        else
        {
            string updateTask = tasks[taskSelect] + " [Completed]";
            tasks[taskSelect] = updateTask;
            Console.WriteLine(taskSelect+1 + ". " + tasks[taskSelect]);
        }
    }
    public static void Main(string[] args)
    {
        AddTask();
        ViewTasks();
        CompleteTask();
    }
}