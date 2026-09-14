using System;

namespace LibraryManagement
{
    public class Book : LibraryItemBase
    {
        public string Author { get; set; }
        public string Category { get; set; }

        public Book(string id, string title, string author, string category = "General")
            : base(id, title)
        {
            Author = author;
            Category = category;
        }

        public override void Describe()
        {
            Console.WriteLine($"Book [ID: {Id}]: {Title}, Author: {Author}, Category: {Category}");
        }
    }
}
