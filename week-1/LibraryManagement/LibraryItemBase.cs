using System;

namespace LibraryManagement
{
    public abstract class LibraryItemBase : ILibraryItem
    {
        public string Id { get; }

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

        protected LibraryItemBase(string id, string title)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id cannot be empty.");

            Id = id;
            Title = title;
        }

        public void CheckOut()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Item is already checked out.");
            IsAvailable = false;
        }

        public void Return()
        {
            if (IsAvailable)
                throw new InvalidOperationException("Item is already available.");
            IsAvailable = true;
        }

        public abstract void Describe();
    }
}