using System.Threading.Tasks;

public class Program
{
    public async Task DownloadDataAsync()
    {
        
        try
        {
            Console.WriteLine("Downloading Data...");
            throw new InvalidOperationException("Download Error.");
            await Task.Delay(3000);
            Console.WriteLine("Downloading Data Finished.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Downloading Data2...");
        await Task.Delay(1000);
        Console.WriteLine("Downloading Data2 Finished.");
    }


    public static async Task Main()
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Program Done.");
    }
}