
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

        item1.describe();
        item2.describe();


        // check out

        Console.WriteLine();
        Console.WriteLine("Check out the book");

        book.checkOut();

        Console.WriteLine("Available: " + book.IsAvailable);
        Console.WriteLine();


        // return

        Console.WriteLine("Return");
        book.Return();

        Console.WriteLine("Available: " + book.IsAvailable);
        Console.WriteLine();


        // value type

        Console.WriteLine("Value Type");

        LibraryBranchInfo branch1 = new LibraryBranchInfo("Downtown Branch", "123 Main St");

        LibraryBranchInfo branch2 = branch1;

        branch2.BranchCode = "456 Elm St";
        branch2.Location = "Uptown Branch";

        Console.WriteLine("Original Branch:");
        Console.WriteLine(branch1.BranchCode);
        Console.WriteLine(branch1.Location);

        Console.WriteLine();

        Console.WriteLine("Copied Branch: ");
        Console.WriteLine(branch2.BranchCode);
        Console.WriteLine(branch2.Location);

        Console.WriteLine();


        // reference type

        Console.WriteLine("Reference Type");

        Book book1 = new Book("Java Programming", "George Orwell");
        Book book2 = book1;

        Console.WriteLine("Before change: ");
        Console.WriteLine("Book 1: " + book1.Title);
        Console.WriteLine("Book 2: " + book2.Title);
        Console.WriteLine(); 
        
        book2.Title = "Animal Farm";
        Console.WriteLine();

        Console.WriteLine("After change: ");
        Console.WriteLine("Book 1: " + book1.Title);
        Console.WriteLine("Book 2: " + book2.Title);

        Console.ReadLine();

    }
}