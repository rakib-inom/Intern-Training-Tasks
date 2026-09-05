using System;

namespace LibraryManagement
{
    public abstract class LibraryItemBase : ILibraryItem
    {
        private string _title; 
        private bool _isAvailable;

        public string Title
        {
            get { return _title; }

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }
                _title = value;
            }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            
        }

        protected LibraryItemBase(string title)
        {
            Title = title;
            _isAvailable = true;
        }

        public void CheckOut()
        {
            if (!_isAvailable)
            {
                Console.WriteLine($"The item '{Title}' is already checked out.");
                return;
            }
            _isAvailable = false;
            Console.WriteLine($"The item '{Title}' has been checked out.");
        }

        public void Return()
        {
            if (_isAvailable)
            {
                Console.WriteLine($"The item '{Title}' is already available.");
                return;
            }
            _isAvailable = true;
            Console.WriteLine($"The item '{Title}' has been returned.");
        }

        protected string GetItemType()
        {
            return GetType().Name;
        }

        public abstract void Describe();
    }
}
