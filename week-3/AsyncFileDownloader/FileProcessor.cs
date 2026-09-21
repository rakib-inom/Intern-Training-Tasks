using System;
using System.Threading.Tasks;

namespace AsyncFileDownloader
{
    public class FileProcessor
    {
        private readonly Random _random = new Random();

        public async Task<int> ProcessFileAsync(FileModel file)
        {
            int delay = _random.Next(1000, 3001);
            Console.WriteLine($"   --> [PROCESS STARTED]  : {file.Content}");

            await Task.Delay(delay);

            int result = file.Content.Length;
            Console.WriteLine($"   --> [PROCESS FINISHED] : {file.Content} Length: {result})");

            return result;
        }
    }
}
