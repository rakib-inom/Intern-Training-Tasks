public class Book : LibraryItemBase
{
    public string Author { get; set; }
    
    public Book(string title, string author) : base(title)
    {
        Author = author;

        ItemType = "Book";
    }

    public override void Describe()
    {
        Console.WriteLine();
        Console.WriteLine("BOOK~~ ");
        Console.WriteLine();
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}