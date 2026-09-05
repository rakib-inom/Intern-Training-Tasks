
public abstract class LibraryItemBase : ILibraryItem
{
    public string Title { get; set; }

    public bool isAvailable { get; protected set; }

    protected string itemType;

    public LibraryItemBase(string title)
    {
        Title = title;
        isAvailable = true;
    }

    public void checkOut()
    {
        isAvailable = false;

        console.WriteLine(Title + " has been checked out.");
    }

    public void Return()
    {
        isAvailable = true;

        console.WriteLine(Title + " has been returned.");
    }

    public abstract void describe();

}