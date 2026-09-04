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
    }
}
