using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncFileDownloader
{
    class Program
    {
        static async Task Main(string[] args)
        {

            List<string> filenames = new List<string>
            {
                "file1.txt",
                "file2.txt",
                "file3.txt",
                "file4.txt",
                "file5.txt"
            };

            Stopwatch stopwatch = Stopwatch.StartNew();

            // FileService অবজেক্ট তৈরি করে কাজ সম্পন্ন করা
            FileService fileService = new FileService();
            var (successCount, failCount) = await fileService.ProcessAllFilesConcurrentlyAsync(filenames);

            stopwatch.Stop();

            Console.WriteLine("\n==================================");
            Console.WriteLine("       FINAL PROCESSING REPORT    ");
            Console.WriteLine("==================================");
            Console.WriteLine($"Successfully Processed : {successCount} files");
            Console.WriteLine($"Failed Downloads       : {failCount} files");
            Console.WriteLine($"Total Elapsed Time     : {stopwatch.Elapsed.TotalSeconds:F2} seconds");
            Console.WriteLine("==================================");
        }
    }
}