using System.Threading.Tasks;

public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        
        try
        {
            await Task.Delay(1000);
            throw new Exception("Process Failure");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.WriteLine("Operation Finished"); 
    }
    public static async Task Main()
    {
        await Task.Run(() => PerformLongOperationAsync());
    }

}
