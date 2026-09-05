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
        console.WriteLine("Book");
        console.WriteLine("Title: " + Title);
        console.WriteLine("Author: " + Author);
        console.WriteLine("Available: " + IsAvailable);
        console.WriteLine();
    }
}