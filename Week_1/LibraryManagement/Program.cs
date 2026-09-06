using System;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book(
                "Clean Code",
                "Robert C. Martin"
            );

            Magazine magazine = new Magazine(
                "National Geographic",
                125
            );


            

            Console.WriteLine("===== POLYMORPHISM =====");

            ILibraryItem item1 = book;
            ILibraryItem item2 = magazine;

            item1.Describe();
            Console.WriteLine();

            item2.Describe();

            Console.WriteLine();



            Console.WriteLine("===== CHECKOUT / RETURN =====");

            Console.WriteLine($"Book Available: {book.IsAvailable}");

            book.CheckOut();

            Console.WriteLine($"Book Available: {book.IsAvailable}");

            book.Return();

            Console.WriteLine($"Book Available: {book.IsAvailable}");

            Console.WriteLine();


        

            Console.WriteLine("===== VALUE TYPE (STRUCT) =====");

            LibraryBranchInfo branch1 = new LibraryBranchInfo
            {
                BranchCode = "BR001",
                Location = "Savar"
            };

            LibraryBranchInfo branch2 = branch1;

            
            branch2.Location = "Dhaka";

            Console.WriteLine(
                $"Original Branch Location: {branch1.Location}"
            );

            Console.WriteLine(
                $"Copied Branch Location: {branch2.Location}"
            );

            Console.WriteLine(
                "Changing the copied struct does NOT affect the original."
            );

            Console.WriteLine();

=

            Console.WriteLine("===== REFERENCE TYPE (CLASS) =====");

            Book book1 = new Book(
                "The Pragmatic Programmer",
                "Andrew Hunt"
            );

            Book book2 = book1;

            
            book2.Title = "Changed Book Title";

            Console.WriteLine(
                $"Original Book Title: {book1.Title}"
            );

            Console.WriteLine(
                $"Copied Book Title: {book2.Title}"
            );

            Console.WriteLine(
                "Changing book2 also affects book1 because both "
                + "variables refer to the same object."
            );

            Console.WriteLine();



            Console.WriteLine("===== ENCAPSULATION =====");

            try
            {
                Book invalidBook = new Book(
                    "",
                    "Unknown Author"
                );
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(
                    $"Validation Error: {ex.Message}"
                );
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}