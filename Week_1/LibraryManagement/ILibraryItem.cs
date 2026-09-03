namespace LibraryManagement
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        bool IsAvailable { get; }
        
        void CheckOut();
        void Return();
        void Describe();
    }
}
