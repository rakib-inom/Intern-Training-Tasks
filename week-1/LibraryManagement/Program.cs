using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Generic Repository Initialization
            Repository<Book> bookRepo = new Repository<Book>();
            Repository<Magazine> magazineRepo = new Repository<Magazine>();

            // 2. HashSet for tracking unique categories
            HashSet<string> categories = new HashSet<string>();

            Console.WriteLine("=== 1. Adding Books (Collections & Generics) ===");

            AddBookWithHandling(bookRepo, categories, new Book("B001", "Clean Code", "Robert C. Martin", "Programming"));
            AddBookWithHandling(bookRepo, categories, new Book("B002", "Design Patterns", "Gang of Four", "Programming")); // Duplicate category "Programming"
            AddBookWithHandling(bookRepo, categories, new Book("B003", "Dune", "Frank Herbert", "Sci-Fi"));

            // 3. Optional Magazine Repository Demo
            magazineRepo.Add(new Magazine("M001", "Tech Monthly", 25));

            Console.WriteLine("\n=== 2. List All Books ===");
            foreach (var b in bookRepo.GetAll())
            {
                b.Describe();
            }

            Console.WriteLine("\n=== 3. Unique Categories (HashSet Demo) ===");
            foreach (var category in categories)
            {
                Console.WriteLine($"- Category: {category}");
            }

            Console.WriteLine("\n=== 4. Exception Handling Demo ===");

            // Test 1: DuplicateItemException
            Console.WriteLine("\n[Testing Duplicate Item Addition]");
            AddBookWithHandling(bookRepo, categories, new Book("B001", "Clean Code Copy", "Someone Else", "Programming"));

            // Test 2: ItemNotFoundException
            Console.WriteLine("\n[Testing Item Search]");
            FindBookWithHandling(bookRepo, "B999"); // Non-existing ID

            // Test 3: Successful search and Checkout
            Console.WriteLine("\n[Testing Successful Search & Checkout]");
            Book foundBook = FindBookWithHandling(bookRepo, "B001");
            if (foundBook != null)
            {
                foundBook.CheckOut();
                Console.WriteLine($"CheckOut Status: IsAvailable = {foundBook.IsAvailable}");
            }
        }

        static void AddBookWithHandling(Repository<Book> repo, HashSet<string> categories, Book book)
        {
            try
            {
                repo.Add(book);
                categories.Add(book.Category);
                Console.WriteLine($"Successfully added: {book.Title}");
            }
            catch (DuplicateItemException ex)
            {
                Console.WriteLine($"Caught Custom Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("-> Operation attempted.");
            }
        }

        static Book FindBookWithHandling(Repository<Book> repo, string id)
        {
            Book item = null;
            try
            {
                item = repo.GetById(id);
                Console.WriteLine($"Found item: {item.Title}");
            }
            catch (ItemNotFoundException ex)
            {
                Console.WriteLine($"Caught Custom Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("-> Operation attempted.");
            }
            return item;
        }
    }
}