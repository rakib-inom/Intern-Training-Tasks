namespace LibraryManagement
{
    public interface ILibraryItem : IIdentifiable
    {
        string Title { get; }
        bool IsAvailable { get; }

        void CheckOut();
        void Return();
        void Describe();
    }
}