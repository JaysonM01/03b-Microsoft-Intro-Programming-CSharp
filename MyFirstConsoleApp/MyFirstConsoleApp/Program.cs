public class Program
{
    public _____ Task ProcessDataChunkAsync(int chunkNumber)
    {
        Console.WriteLine($"Processing chunk {chunkNumber}...");
        _____ Task.Delay(1000); // Simulate processing time
        Console.WriteLine($"Completed processing of chunk {chunkNumber}.");
    }


    public _____ Task ProcessLargeDatasetAsync(int numberOfChunks)
    {
        var tasks = new List<Task>();

        // Start processing each chunk concurrently
        for (int i = 1; i <= numberOfChunks; i++)
        {
            tasks.Add(ProcessDataChunkAsync(i));
        }

        // Wait for all tasks to complete
        _____ Task.WhenAll(tasks);

        Console.WriteLine("All data chunks processed.");
    }

    public static _____ Task Main(string[] args)
    {
        Program program = new Program();
        _____ program.ProcessLargeDatasetAsync(5); // Process 5 chunks
    }
}
