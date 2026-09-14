
public interface ILibraryItem
{
    string Title { get; }
    bool IsAvailable { get;}

    void CheckOut();
    void Describe();
    void Return();
}