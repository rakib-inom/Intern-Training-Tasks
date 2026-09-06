namespace LibraryManagementConsoleApp;

public interface ILibraryItem
{
    string Title { get; set; }

    bool IsAvailable { get; }

    void CheckOut();

    void Return();

    string Describe();
}