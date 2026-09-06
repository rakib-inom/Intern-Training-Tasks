namespace LibraryManagementConsoleApp;

public abstract class LibraryItemBase : ILibraryItem
{
    // Encapsulation
    private string _title;
    private bool _isAvailable;

    // Protected member
    // Only this class and derived classes can access it.
    protected string ItemType { get; set; }

    protected LibraryItemBase(string title, string itemType)
    {
        Title = title;
        ItemType = itemType;
        _isAvailable = true;
    }

    // Public property with validation
    public string Title
    {
        get
        {
            return _title;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title cannot be empty.");
            }

            _title = value;
        }
    }

    public bool IsAvailable
    {
        get
        {
            return _isAvailable;
        }
    }

    public void CheckOut()
    {
        if (!_isAvailable)
        {
            Console.WriteLine($"{Title} is already checked out.");
            return;
        }

        _isAvailable = false;

        Console.WriteLine($"{Title} has been checked out.");
    }

    public void Return()
    {
        if (_isAvailable)
        {
            Console.WriteLine($"{Title} is already available.");
            return;
        }

        _isAvailable = true;

        Console.WriteLine($"{Title} has been returned.");
    }

    // Derived classes must implement this method
    public abstract string Describe();
}