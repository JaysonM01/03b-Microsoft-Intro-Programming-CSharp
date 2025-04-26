using System.Threading.Tasks;

public class Program
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Downloading Data...");
        await Task.Delay(3000);
        Console.WriteLine("Downloading Finished.");
    }

    public static async Task Main()
    {
        Program program = new Program();
        await program.DownloadDataAsync();
        Console.WriteLine("Program Done.");
    
    }
}