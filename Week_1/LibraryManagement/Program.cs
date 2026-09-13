using System;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Library Items...");

            Book book1 = new Book(
                "B001",
                "Clean Code",
                "Robert C. Martin",
                "Programming"
            );
            Book book2 = new Book(
                "B002",
                "The Pragmatic Programmer",
                "Andrew Hunt",
                "Programming"
            );
            Book book3 = new Book(
                "B003",
                "Design Patterns",
                "Erich Gamma",
                "Software Engineering"
            );

            Magazine magazine1 = new Magazine(
                "National Geographic",
                125
            );

            Console.WriteLine();

            Console.WriteLine("Book and Magazine Details:");

            book1.Describe();
            book2.Describe();
            book3.Describe();
            magazine1.Describe();

            Console.WriteLine();





            Console.WriteLine("===== POLYMORPHISM =====");

            ILibraryItem item1 = book1;
            ILibraryItem item2 = magazine1;

            item1.Describe();
            Console.WriteLine();

            item2.Describe();

            Console.WriteLine();



            Console.WriteLine("===== CHECKOUT / RETURN =====");

            book1.CheckOut();
            Console.WriteLine($"After checkout, is '{book1.Title}' available? {book1.IsAvailable}");

            book1.Return();
            Console.WriteLine($"After return, is '{book1.Title}' available? {book1.IsAvailable}");

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



            Console.WriteLine("===== REFERENCE TYPE (CLASS) =====");

            Book referenceBook1 = book2;

            Book referenceBook2 = referenceBook1;

            referenceBook2.Title = "Changed Book Title";

            Console.WriteLine(
                $"Original Book Title: {referenceBook1.Title}"
            );

            Console.WriteLine(
                $"Copied Book Title: {referenceBook2.Title}"
            );

            Console.WriteLine(
                "Changing referenceBook2 also affects referenceBook1 because both "
                + "variables refer to the same object."
            );

            Console.WriteLine();

            Console.WriteLine("Repository Operations:");

            Repository<Book> bookRepository = new Repository<Book>();

            Console.WriteLine("Adding books to the repository...");

            try
            {
                bookRepository.Add(book1);
                Console.WriteLine("Book B001 added successfully.");

                bookRepository.Add(book2);
                Console.WriteLine("Book B002 added successfully.");

                bookRepository.Add(book3);
                Console.WriteLine("Book B003 added successfully.");
            }
            catch (DuplicateItemException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finished adding books.");
            }

            Console.WriteLine();

            Console.WriteLine("All books");

            List<Book> allBooks = bookRepository.GetAll();

            foreach(Book book in allBooks)
            {
                book.Describe();
            }
            Console.WriteLine();



            Console.WriteLine("----- Find Book By ID -----");

            try
            {
                Book foundBook = bookRepository.GetById("B002");

                Console.WriteLine("Book found:");

                foundBook.Describe();
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine($"Not Found: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation attempted.");
            }

            Console.WriteLine();


            Console.WriteLine("----- Testing Duplicate ID -----");

            try
            {
                Book duplicateBook = new Book(
                    "B001",
                    "Another Book",
                    "Another Author",
                    "Programming"
                );

                bookRepository.Add(duplicateBook);
            }
            catch (DuplicateItemException ex)
            {
                Console.WriteLine($"Duplicate Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation attempted.");
            }

            Console.WriteLine();

            Console.WriteLine("----- Testing Missing ID -----");

            try
            {
                Book missingBook = bookRepository.GetById("B999");

                missingBook.Describe();
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine($"Not Found: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation attempted.");
            }

            Console.WriteLine();

            Console.WriteLine("----- Removing Book -----");

            try
            {
                bookRepository.Remove("B003");

                Console.WriteLine(
                    "Book B003 removed successfully."
                );
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine($"Not Found: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation attempted.");
            }

            Console.WriteLine();

            Console.WriteLine("Books After Removal");

            foreach (Book book in bookRepository.GetAll())
            {
                book.Describe();
            }

            Console.WriteLine();


            Console.WriteLine("Unique Categories");

            HashSet<string> categories = new HashSet<string>();

            foreach (Book book in bookRepository.GetAll())
            {
                categories.Add(book.Category);
            }

            foreach (string category in categories)
            {
                Console.WriteLine(category);
            }

            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}