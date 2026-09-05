public class Book : LibraryItemBase
{
    public string Author { get; set; }
    
    public Book(string title, string author) : base(title)
    {
        Author = author;

        itemType = "Book";
    }

    public override void describe()
    {
        console.WriteLine("Book");
        console.WriteLine("Title: " + Title);
        console.WriteLine("Author: " + Author);
        console.WriteLine("Available: " + isAvailable);
        console.WriteLine();
    }
}