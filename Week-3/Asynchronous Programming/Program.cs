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

    }
}