namespace LibraryManagement
{
    public class Book : LibraryItemBase
    {
        public string Author { get; set; }
        public Book (string title, string author)
            : base(title)
        {
            Author = author;
        }
        public override void Describe()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}");
        }
    }
}
