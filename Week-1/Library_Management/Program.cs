
using System.Runtime.InteropServices;

class Program
{   
    static void Main()
    {
        Console.WriteLine("Welcome to the Library Management System!");
        Console.WriteLine();

        Repository<Book> bookRepo = new Repository<Book>();

        HashSet<string> categories = new HashSet<string>();

        // add book 1

        try
        {
            Book book1 = new Book(

                 "B1",
                 "C# basics",
                 "John",
                 "Programming"

             );

            bookRepo.Add(book1);
            categories.Add(book1.Category);

            Console.WriteLine("Book added successfully");
        }

        catch(DuplicateItemException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("operation attempted");
            Console.WriteLine();
        }


        // add book 2

        try
        {
            Book book2 = new Book(

                 "B2",
                 "Python basics",
                 "David",
                 "Programming"

             );

            bookRepo.Add(book2);
            categories.Add(book2.Category);

            Console.WriteLine("Book added successfully");
        }

        catch (DuplicateItemException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("operation attempted");
            Console.WriteLine();

        }


        // add book 3

        try
        {
            Book book3 = new Book(

                 "B3",
                 "Kobor",
                 "Jashim Uddin",
                 "Poem"

             );

            bookRepo.Add(book3);
            categories.Add(book3.Category);

            Console.WriteLine("Book added successfully");
        }

        catch (DuplicateItemException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("operation attempted");
            Console.WriteLine();
        }


        // list of all books

        Console.WriteLine();
        Console.WriteLine(" ALL BOOKS- ");

        foreach(Book book in bookRepo.getAll())
        {
            book.Describe();
        }


        // find my book

        Console.WriteLine();
        Console.WriteLine(" FIND BOOK ");
        Console.WriteLine();

        try
        {
            Book book = bookRepo.GetById("B2");
            
            book.Describe();

        }

        catch(ItemNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("Opreation attempted");
            Console.WriteLine();
        }


        // check out book

        Console.WriteLine();
        Console.WriteLine(" CHECK OUT BOOK ");
        Console.WriteLine();

        try
        {
            Book book = bookRepo.GetById("B1");

            book.CheckOut();

        }

        catch (ItemNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("Opreation attempted");
            Console.WriteLine();
        }


        // unique categories

        Console.WriteLine();
        Console.WriteLine(" UNIQUE CATEGORIES ");
        Console.WriteLine();

        foreach (string category in categories)
        {
            Console.WriteLine(category);
        }


        // duplicate test

        Console.WriteLine();
        Console.WriteLine(" DUPLICATE TEST ");
        Console.WriteLine();

        try
        {
            Book dupbook = new Book(

                 "B1",
                 "Shesher Kobita",
                 "Tagore",
                 "Novel"

             );

            bookRepo.Add(dupbook);
        }

        catch (DuplicateItemException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("operation attempted");
            Console.WriteLine();
        }


        // not found test

        Console.WriteLine();
        Console.WriteLine(" NOT FOUND TEST ");
        Console.WriteLine();

        try
        {
            Book book = bookRepo.GetById("B67");

            book.Describe();
        }

        catch (ItemNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("Opreation attempted");
        }

        Console.WriteLine();
        Console.ReadLine();


        // create objects

        //Book book = new Book("C# Programming", "John");
        //Magazine magazine1 = new Magazine("Tech World", 202);


        //// polymorphism

        //ILibraryItem item1 = book;
        //ILibraryItem item2 = magazine1;

        //item1.Describe();
        //item2.Describe();


        //// check out

        //Console.WriteLine();
        //Console.WriteLine("CHECK OUT ");
        //Console.WriteLine();

        //book.CheckOut();

        //Console.WriteLine("Available: " + book.IsAvailable);
        //Console.WriteLine();


        //// return

        //Console.WriteLine();
        //Console.WriteLine("RETURN ");
        //Console.WriteLine();
        //book.Return();

        //Console.WriteLine("Available: " + book.IsAvailable);
        //Console.WriteLine();


        //// value type

        //Console.WriteLine();
        //Console.WriteLine("VALUE TYPE ");
        //Console.WriteLine();

        //LibraryBranchInfo branch1 = new LibraryBranchInfo("Downtown Branch", "123 Main St");

        //LibraryBranchInfo branch2 = branch1;

        //branch2.BranchCode = "B02";
        //branch2.Location = "Savar";

        //Console.WriteLine("Original Branch:" + branch1.BranchCode + ", " + branch1.Location);
        //Console.WriteLine();

        //Console.WriteLine("Copied Branch: " + branch2.BranchCode + ", " + branch2.Location);
        //Console.WriteLine();


        //// reference type

        //Console.WriteLine();
        //Console.WriteLine("REFERENCE TYPE ");
        //Console.WriteLine();

        //Book book1 = new Book("Java Programming", "George");
        //Book book2 = book1;

        //Console.WriteLine("Before change: ");
        //Console.WriteLine("Book 1: " + book1.Title);
        //Console.WriteLine("Book 2: " + book2.Title); 

        //book2.Title = "Python Programming";
        //Console.WriteLine();

        //Console.WriteLine("After change: ");
        //Console.WriteLine("Book 1: " + book1.Title);
        //Console.WriteLine("Book 2: " + book2.Title);



    }
}