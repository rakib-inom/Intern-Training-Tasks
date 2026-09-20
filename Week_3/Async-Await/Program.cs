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
    }
}
}
