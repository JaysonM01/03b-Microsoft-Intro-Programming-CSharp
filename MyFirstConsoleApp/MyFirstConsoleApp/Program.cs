public class Program
{
    public async void DownloadDataAsync()
    {
        Console.WriteLine("Downloading Data...");
        await Task.Delay(2000);
        Console.WriteLine("Downloading Finished.");
    }
    
}