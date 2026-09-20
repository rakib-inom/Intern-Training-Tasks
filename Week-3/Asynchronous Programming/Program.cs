class Program
{
    
    static Random rm = new Random();

    static async Task<string> DownloadFileAsync(string filename)
    {
        Console.WriteLine($"download started: {filename} ");
        
        Stopwatch stp = new Stopwatch().StartNew();
        
        int time= rm.Next(1000, 30001);
        await Task.Delay(time);

        if (rm.Next(1,4) == 1)
        {
            throw new Exception($"download failed: {filename} ");
        }

        stp.Stop();
        Console.WriteLine($"download finished: {filename} ({stp.ElapsedMiliseconds} ms)");
        
        string message = $"this is the content of {filename}";
        return message;
    }

    static async Task<int> ProcessFileAsync(string contents)
    {
        Console.WriteLine($"Process started: {contents}");
        
        int time = rm.Next(1000, 30001);
        await Task.Delay(time);

        int result = contents.Length;
        Console.WriteLine($"process finished: {Result} = {result");
        
        return result;
    }

    static async Task Main()
    {
            Stopwatch totalTime = Stopwatch.StartNew();

            List<string> fileNames = new List<string>
            {
                "file1.txt",
                "file2.txt",
                "file3.txt"
            };

            int successCount = 0;
            int failedCount = 0;

            List<Task<int>> processTask = new List<Task<int>>();

            List<Task<string>> downloadTask = new List<Task<string>>();

            foreach(string file in fileNames)
            {
                downloadTask.Add(DownloadFileAsync(fileNames)) ;
            }

            while(downloadTask.Count > 0)
            {
                Task<string> finishedTask = await Task.WhenAny(downloadTask);
                downloadTask.Remove(finishedTask);

                try
                {
                    string contents = await finishedTask;
                    successCount++;

                    Task<int> processTask = ProcessFileAsync(contents);
                    processTask.Add(processTask);
                }

                catch(Exception e)
                {
                    failedCount++;
                    Console.WriteLine($"error: {e.Message}");
                }
            }

            await processTask.WhenAll(processTask);
            totalTime.Stop();
            
            Console.WriteLine();

            Console.WriteLine(" FINAL RESULT ");

            Console.WriteLine($"files successed: {successCount}");
            Console.WriteLine($"files failed: {failedCount}");
            Console.WriteLine($"total time: {totalTime.TotalMilliseconds}ms");
            Console.WriteLine();
            Console.ReadLine();
    }
}