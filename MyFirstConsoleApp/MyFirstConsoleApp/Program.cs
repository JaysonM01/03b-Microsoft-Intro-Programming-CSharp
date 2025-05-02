using System.Threading.Tasks;

public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Operation Finished");
    }
    public static async Task Main()
    {
        await Task.Run(() => PerformLongOperationAsync());
    }

}
