public interface ILibraryItem
{
    string Title { get; }
    bool IsAvailable { get; }

    void CheckOut();
    void Return();
    void Describe();
}
