
using System.Runtime.InteropServices;

class Program
{
    static void main()
    {
        Console.WriteLine("Welcome to the Library Management System!");
        Console.WriteLine();

        // create objects

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Magazine magazine1 = new Magazine("National Geographic", 202);
        

        // polymorphism

        book1.describe();
        magazine1.describe();


        // check out

        Console.WriteLine();
        Console.WriteLine("Check out the book");

        book1.checkOut();

        Console.WriteLine("available: " + book1.IsAvailable);
        Console.WriteLine();


        // return

        Console.WriteLine("Return");
        book1.Return();

        Console.WriteLine("available: " + book1.IsAvailable);
        Console.WriteLine();


        // value type

        Console.WriteLine("Value Type");

        LibraryBranchInfo branch1 = new LibraryBranchInfo("Downtown Branch", "123 Main St");

        LibraryBranchInfo branch2 = branch1;

        branch2.branchcode = "456 Elm St";
        branch2.location = "Uptown Branch";

        Console.WriteLine("Original Branch: " + branch1.branchcode + ", " + branch1.location);
        Console.WriteLine();


        // 


    }
}