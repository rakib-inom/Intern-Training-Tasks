

public abstract class LibraryItemBase : ILibraryItem
{
    public string Title { get; set; }

    public bool IsAvailable { get; protected set; }

    protected string ItemType;

    public LibraryItemBase(string title)
    {
        Title = title;
        IsAvailable = true;
    }

    public void CheckOut()
    {
  
        IsAvailable = false;

        Console.WriteLine(Title + " is checked out.");
    }

    public void Return()
    {
        IsAvailable = true;

        Console.WriteLine(Title + " is returned.");
    }

    public abstract void Describe();

}




