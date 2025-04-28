public class Program
{
public _____ Task<string> DownloadFileAsync(string fileName)
{
    Console.WriteLine($"Starting download of {fileName}...");
    _____ Task.Delay(3000); // Simulate a 3-second download time
    Console.WriteLine($"Completed download of {fileName}.");
    return $"{fileName} content";
}

public _____ Task DownloadFilesAsync()
{
    // Start downloading "File1.txt" and "File2.txt" concurrently
    var downloadTask1 = DownloadFileAsync("File1.txt");
    var downloadTask2 = DownloadFileAsync("File2.txt");


    // Wait for both downloads to complete
    _____ Task.WhenAll(downloadTask1, downloadTask2);
    Console.WriteLine("All downloads completed.");
}

public static _____ Task Main(string[] args)
{
    Program program = new Program();
    _____ program.DownloadFilesAsync();
}
}
