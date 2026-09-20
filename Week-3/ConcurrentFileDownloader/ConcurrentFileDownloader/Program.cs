using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static Random random = new Random();

    static int successCount = 0;
    static int failedCount = 0;

    // Download File
    static async Task<string> DownloadFileAsync(string filename)
    {
        Console.WriteLine($"Downloading {filename}...");

        // Random download time: 1 to 3 seconds
        int delay = random.Next(1000, 3001);

        await Task.Delay(delay);

        // 1 in 3 chance of failure
        if (random.Next(1, 4) == 1)
        {
            throw new Exception($"Download failed for {filename}");
        }

        Console.WriteLine(
            $"{filename} downloaded successfully in {delay / 1000.0:F2} seconds."
        );

        return $"Contents of {filename}";
    }

    // Process File
    static async Task<int> ProcessFileAsync(string contents)
    {
        Console.WriteLine($"Processing: {contents}");

        // Random processing time: 1 to 3 seconds
        int delay = random.Next(1000, 3001);

        await Task.Delay(delay);

        int result = contents.Length;

        Console.WriteLine(
            $"Processing finished: {contents} | Result = {result}"
        );

        return result;
    }

    // Main Method
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        List<string> filenames = new List<string>
        {
            "File1.txt",
            "File2.txt",
            "File3.txt"
        };

        Console.WriteLine("=================================");
        Console.WriteLine(" Concurrent File Downloader");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // Start all downloads concurrently
        List<Task<string>> downloadTasks = new List<Task<string>>();

        foreach (string filename in filenames)
        {
            downloadTasks.Add(DownloadFileAsync(filename));
        }

        // Store processing tasks
        List<Task<int>> processingTasks = new List<Task<int>>();

        // Process each file as soon as its download finishes
        while (downloadTasks.Count > 0)
        {
            Task<string> completedTask =
                await Task.WhenAny(downloadTasks);

            downloadTasks.Remove(completedTask);

            try
            {
                string contents = await completedTask;

                successCount++;

                Task<int> processingTask =
                    ProcessFileAsync(contents);

                processingTasks.Add(processingTask);
            }
            catch (Exception ex)
            {
                failedCount++;

                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        // Wait for all processing tasks to finish
        if (processingTasks.Count > 0)
        {
            await Task.WhenAll(processingTasks);
        }

        stopwatch.Stop();

        // Final Report
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine(" Final Report");
        Console.WriteLine("=================================");

        Console.WriteLine($"Files succeeded : {successCount}");
        Console.WriteLine($"Files failed    : {failedCount}");
        Console.WriteLine(
            $"Total time      : {stopwatch.Elapsed.TotalSeconds:F2} seconds"
        );

        Console.WriteLine("=================================");
    }
}