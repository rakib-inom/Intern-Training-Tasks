namespace AsyncFileDownloader
{
    public class FileModel
    {
        public string Name { get; set; }// to hold file name
        public string Content { get; set; } // to hold the info about the file

        public FileModel(string name) // constructor. 
        {
            Name = name;
        }
    }
}