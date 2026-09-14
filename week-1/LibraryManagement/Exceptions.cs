using System;

namespace LibraryManagement
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message) : base(message)
        {
        }
    }

    public class DuplicateItemException : Exception
    {
        public DuplicateItemException(string message) : base(message)
        {
        }
    }
}
