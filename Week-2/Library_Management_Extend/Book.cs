public class Book : LibraryItemBase, IIdentifiable
{
    public string Author { get; set; }
    public string Category { get; set; }
    public string ID { get; }
    
    public Book(string id, string title, string author, string category) : base(title)
    {
        ID = id;
        Author = author;
        ItemType = "Book";
        Category = category;
        
    }

    public override void Describe()
    {
        Console.WriteLine();
        //Console.WriteLine("BOOK ");
        //Console.WriteLine();
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Category: " + Category);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}