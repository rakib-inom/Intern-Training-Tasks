using System;

namespace LibraryManagement
{
    public class Book : LibraryItemBase, IIdentifiable
    {
        public string Id { get; }
        public string Author { get; set; }
        public string Category { get; set; }
       

        public Book(string id, string title, string author, string category) : base(title)
        {
            if(string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id cannot be null or empty.");
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Author cannot be null or empty.");
            }
            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentException("Category cannot be null or empty.");
            }

            Id = id;
            Author = author;
            Category = category;

            
        }

        public override void Describe()
        {
            Console.WriteLine($"Book | ID: {Id} | Title: {Title} | Author: {Author} | Category: {Category} | Available: {IsAvailable}");
        }
    }
}
