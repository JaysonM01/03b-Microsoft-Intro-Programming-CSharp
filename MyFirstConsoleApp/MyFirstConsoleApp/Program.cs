using System.Threading.Tasks;

public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        await Task.Delay(1000);
    }
    public static async Task Main()
    {
        await Task.Run(() => PerformLongOperationAsync());
    }

}
