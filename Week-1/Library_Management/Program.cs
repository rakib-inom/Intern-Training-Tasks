
using System.Runtime.InteropServices;

class Program
{   
    static void Main()
    {
        Console.WriteLine("Welcome to the Library Management System!");
        Console.WriteLine();

        // create objects

        Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Magazine magazine1 = new Magazine("National Geographic", 202);
        

        // polymorphism

        ILibraryItem item1 = book;
        ILibraryItem item2 = magazine1;

        item1.Describe();
        item2.Describe();


        // check out

        Console.WriteLine();
        Console.WriteLine("CHECK OUT~~ ");
        Console.WriteLine();

        book.CheckOut();

        Console.WriteLine("Available: " + book.IsAvailable);
        Console.WriteLine();


        // return

        Console.WriteLine();
        Console.WriteLine("RETURN~~ ");
        Console.WriteLine();
        book.Return();

        Console.WriteLine("Available: " + book.IsAvailable);
        Console.WriteLine();


        // value type

        Console.WriteLine();
        Console.WriteLine("VALUE TYPE~~ ");
        Console.WriteLine();

        LibraryBranchInfo branch1 = new LibraryBranchInfo("Downtown Branch", "123 Main St");

        LibraryBranchInfo branch2 = branch1;

        branch2.BranchCode = "456 Elm St";
        branch2.Location = "Uptown Branch";

        Console.WriteLine("Original Branch:" + branch1.BranchCode + ", " + branch1.Location);
        Console.WriteLine();

        Console.WriteLine("Copied Branch: " + branch2.BranchCode + ", " + branch2.Location);
        Console.WriteLine();


        // reference type

        Console.WriteLine();
        Console.WriteLine("REFERENCE TYPE~~ ");
        Console.WriteLine();

        Book book1 = new Book("Java Programming", "George Orwell");
        Book book2 = book1;

        Console.WriteLine("Before change: ");
        Console.WriteLine("Book 1: " + book1.Title);
        Console.WriteLine("Book 2: " + book2.Title); 
        
        book2.Title = "Animal Farm";
        Console.WriteLine();

        Console.WriteLine("After change: ");
        Console.WriteLine("Book 1: " + book1.Title);
        Console.WriteLine("Book 2: " + book2.Title);

        Console.ReadLine();

    }
}