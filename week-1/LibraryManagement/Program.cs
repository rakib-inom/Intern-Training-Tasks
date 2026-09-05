using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibraryItem book = new Book("Clean Code", "Robert C. Martin");
            ILibraryItem magazine = new Magazine("Tech Monthly", 25);

            book.Describe();
            magazine.Describe();

            Console.WriteLine($"Book Available: {book.IsAvailable}");

            book.CheckOut();

            Console.WriteLine($"Book Available after checkout: {book.IsAvailable}");

            book.Return();

            Console.WriteLine($"Book Available after return: {book.IsAvailable}");
        }
    }
}
