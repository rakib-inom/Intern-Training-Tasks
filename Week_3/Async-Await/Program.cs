using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async-Await{
    class program
{
    static Random random = new Random();

    static async Task Main(string[] args)
    {
        List<string> files = new List<string> { "file1.txt", "file2.txt", "file3.txt" };

        Stopwatch stopwatch = Stopwatch.StartNew();

        Console.WriteLine("Starting file downloads...");



        List<Task<string>> downloadTasks = new List<Task<string>>();

        foreach(string file in files)
        {
            Task<string> task = DownloadFileAsync(file);
            downloadTasks.Add(task);
        }



        List<Task<int>> processingTasks = new List<Task<int>>();

        int successfulFiles = 0;
        int failedFiles = 0;


        while(downloadTasks.Count > 0)
        {
            Task<string> completedTask = await Task.WhenAny(downloadTasks);
            downloadTasks.Remove(completedTask);


            try
            {
                string contents = await completedTask;
                successfulFiles++;
                Console.WriteLine("[Success] Download completed");

                Task<int> processingTask = ProcessFileAsync(contents);
                processingTasks.Add(processingTask);
            }
            catch (Exception ex)
            {
                failedFiles++;
                Console.WriteLine($"[Error] Download failed: {ex.Message}");
            }
        }
    }
}
}
