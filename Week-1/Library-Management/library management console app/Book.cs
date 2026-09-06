
namespace LibraryManagementConsoleApp;

public class Book : LibraryItemBase
{
    private string _author;

    public Book(string title, string author)
        : base(title, "Book")
    {
        Author = author;
    }

    public string Author
    {
        get
        {
            return _author;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Author cannot be empty.");
            }

            _author = value;
        }
    }

    public override string Describe()
    {
        return $"Book: {Title} | Author: {Author} | Available: {IsAvailable}";
    }
}