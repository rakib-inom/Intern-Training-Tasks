using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static Random random = new Random();

        static async Task Main(string[] args)
        {
            List<string> files = new List<string> { "file1.txt", "file2.txt", "file3.txt" };

            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine("Starting file downloads...");



            List<Task<string>> downloadTasks = new List<Task<string>>();

            foreach (string file in files)
            {
                Task<string> task = DownloadFileAsync(file);
                downloadTasks.Add(task);
            }



            List<Task<int>> processingTasks = new List<Task<int>>();

            int successfulFiles = 0;
            int failedFiles = 0;


            while (downloadTasks.Count > 0)
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


            Console.WriteLine("All downloads completed. Starting file processing...");

            await Task.WhenAll(processingTasks);
            Console.WriteLine("All file processing completed.");

            stopwatch.Stop();

            Console.WriteLine("\nFINAL RESULTS");

            Console.WriteLine($"Successful files : {successfulFiles}");

            Console.WriteLine($"Failed files : {failedFiles}");

            Console.WriteLine(
                $"Total time : " +
                $"{stopwatch.Elapsed.TotalSeconds:F2} seconds"
            );
        }





        static async Task<string> DownloadFileAsync(string fileName)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine($"[Download start] {fileName}");

            int delay = random.Next(1000, 3001);
            await Task.Delay(delay);


            int chance = random.Next(1, 4);

            if (chance == 1)
            {
                stopwatch.Stop();
                throw new Exception($"{fileName} Download failed");
            }

            stopwatch.Stop();

            Console.WriteLine(
                   $"[DOWNLOAD FINISHED] {fileName} " +
                   $"in {stopwatch.Elapsed.TotalSeconds:F2} seconds"
               );

            string contents = $"Contents of {fileName}";

            return contents;
        }



        static async Task<int> ProcessFileAsync(string contents)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine(
                   "[PROCESS START]"
               );

            int delay = random.Next(1000, 3001);
            await Task.Delay(delay);

            int result = contents.Length;
            stopwatch.Stop();

            Console.WriteLine(
                 $"[PROCESS FINISHED] " +
                 $"Result = {result}, " +
                 $"Time = {stopwatch.Elapsed.TotalSeconds:F2} seconds"
             );

            return result;
        }
    }
}
