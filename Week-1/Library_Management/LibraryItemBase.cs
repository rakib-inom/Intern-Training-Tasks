
public abstract class LibraryItemBase : ILibraryItem
{
    public string Title { get; private set; }

    public bool IsAvailable { get; protected set; }

    protected string ItemType( get; set; );

    public LibraryItemBase(string title)
    {
        Title = title;
        IsAvailable = true;
    }

    public void CheckOut()
    {
  
        if (IsAvailable)
        {
            IsAvailable = false;

            Console.WriteLine(Title + " has been checked out.");

        }
        else
        {
            Console.WriteLine(Title + " is already checked out.")
        }
    }

    public void Return()
    {
        IsAvailable = true;

        Console.WriteLine(Title + " has been returned.");
    }

    public abstract void Describe();

}




