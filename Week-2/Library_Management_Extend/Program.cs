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

        catch (DuplicateItemException ex)
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

        foreach (Book book in bookRepo.getAll())
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

        catch (ItemNotFoundException ex)
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
    }
}

