
public interface ILibraryItem
{
    string Title { get; set; }
    bool IsAvailable { get; }

    void CheckOut();
    void describe();
    void Return();
}