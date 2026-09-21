using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncFileDownloader
{
    public class FileService
    {
        private readonly FileDownloader _downloader;
        private readonly FileProcessor _processor;

        public FileService()
        {
            _downloader = new FileDownloader();
            _processor = new FileProcessor();
        }

        public async Task<(int successCount, int failCount)> ProcessAllFilesConcurrentlyAsync(List<string> filenames)
        {
            int successCount = 0;
            int failCount = 0;

            List<Task<FileModel>> downloadTasks = new List<Task<FileModel>>();

            foreach (string filename in filenames)
            {
                Task<FileModel> task = _downloader.DownloadFileAsync(filename);
                downloadTasks.Add(task);
            }

            List<Task<int>> processingTasks = new List<Task<int>>();

            
            while (downloadTasks.Count > 0)
            {
                Task<FileModel> completedTask = await Task.WhenAny(downloadTasks);
                downloadTasks.Remove(completedTask);

                try
                {
                    FileModel downloadedFile = await completedTask;
                    successCount++;

                    Task<int> pTask = _processor.ProcessFileAsync(downloadedFile);
                    processingTasks.Add(pTask);
                }
                catch (Exception ex)
                {
                    failCount++;
                    Console.WriteLine($"   [ERROR]  {ex.Message}");
                }
            }

          
            await Task.WhenAll(processingTasks);

            return (successCount, failCount);
        }
    }
}