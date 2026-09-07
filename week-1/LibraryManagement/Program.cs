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

            // Value Type demonstration
            LibraryBranchInfo branch1 = new LibraryBranchInfo
            {
                BranchCode = "BR001",
                Location = "Dhaka"
            };

            LibraryBranchInfo branch2 = branch1;
            branch2.Location = "Chittagong";

            Console.WriteLine("\nValue Type Demonstration:");
            Console.WriteLine($"Original Branch Location: {branch1.Location}");
            Console.WriteLine($"Copied Branch Location: {branch2.Location}");

            // Reference Type demonstration
            Book originalBook = new Book("Clean Code", "Robert C. Martin");

            Book copiedBook = originalBook;
            copiedBook.Author = "Changed Author";

            Console.WriteLine("\nReference Type Demonstration:");
            Console.WriteLine($"Original Book Author: {originalBook.Author}");
            Console.WriteLine($"Copied Book Author: {copiedBook.Author}");
        }
    }
}
