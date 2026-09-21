using System;
using System.Threading.Tasks;

namespace AsyncFileDownloader
{
    public class FileDownloader
    {
        private readonly Random _random = new Random();

        public async Task<FileModel> DownloadFileAsync(string filename)
        {
            int delay = _random.Next(1000, 3001);
            Console.WriteLine($"[DOWNLOAD STARTED]  : {filename}");

            await Task.Delay(delay);// to calculate how long the file take time for downloaded.

            if (_random.Next(1, 4) == 1)
            {
                throw new Exception($"Failed to download {filename} due to a network issue!");
            }

            Console.WriteLine($"[DOWNLOAD FINISHED] : {filename} (time: {delay} ms)");

            return new FileModel(filename)
            {
                Content = $"My name is rabu - {filename}" // it will go service class 
            };
        }
    }
}