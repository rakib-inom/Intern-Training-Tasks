namespace LibraryManagement
{
    public abstract class LibraryItemBase : ILibraryItem
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");
                _title = value;
            }

        }
        public bool IsAvailable { get; protected set; } = true;
        public void CheckOut()
        {
            if (!IsAvailable)
                throw new InvalidOperationException(" Item is already checked out.");
            IsAvailable = false;
        }
        public void Return()
        {
            if (IsAvailable)
                throw new InvalidOperationException("Item is already available.");
            IsAvailable = true;
        }
        protected LibraryItemBase(string title)
        {
            Title= title;
        }
        public abstract void Describe();

    }

}
