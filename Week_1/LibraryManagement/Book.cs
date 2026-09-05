using System;

namespace LibraryManagement
{
    public class Book : LibraryItemBase
    {
        private string _author;

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author cannot be null or empty.");
                }
                _author = value;
            }
        }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public override void Describe()
        {
            Console.WriteLine($"Book: {Title} by {Author}");
        }
    }
}
