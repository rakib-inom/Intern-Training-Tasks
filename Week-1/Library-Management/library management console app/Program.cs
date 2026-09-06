namespace LibraryManagementConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("     LIBRARY MANAGEMENT CONSOLE APP");
        Console.WriteLine("======================================");
        Console.WriteLine();

        // =====================================
        // STEP 1: Create Library Items
        // =====================================

        Book book = new Book(
            "C# Programming",
            "John Smith"
        );

        Magazine magazine = new Magazine(
            "Tech Monthly",
            25
        );

        // =====================================
        // STEP 2: Polymorphism
        // =====================================

        Console.WriteLine("----- POLYMORPHISM -----");

        ILibraryItem item1 = book;
        ILibraryItem item2 = magazine;

        Console.WriteLine(item1.Describe());
        Console.WriteLine(item2.Describe());

        Console.WriteLine();

        // =====================================
        // STEP 3: Check Out and Return
        // =====================================

        Console.WriteLine("----- CHECK OUT / RETURN -----");

        Console.WriteLine("Before checkout:");
        Console.WriteLine(book.Describe());

        book.CheckOut();

        Console.WriteLine("After checkout:");
        Console.WriteLine(book.Describe());

        book.Return();

        Console.WriteLine("After return:");
        Console.WriteLine(book.Describe());

        Console.WriteLine();

        // =====================================
        // STEP 4: Encapsulation
        // =====================================

        Console.WriteLine("----- ENCAPSULATION -----");

        Console.WriteLine($"Book Title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Available: {book.IsAvailable}");

        Console.WriteLine();

        // =====================================
        // STEP 5: Value Type - Struct
        // =====================================

        Console.WriteLine("----- VALUE TYPE DEMO -----");

        LibraryBranchInfo branch1 =
            new LibraryBranchInfo("B001", "Dhaka");

        LibraryBranchInfo branch2 = branch1;

        // Change copied struct
        branch2.Location = "Savar";

        Console.WriteLine(
            $"Original Branch: {branch1.BranchCode} - {branch1.Location}"
        );

        Console.WriteLine(
            $"Copied Branch:   {branch2.BranchCode} - {branch2.Location}"
        );

        Console.WriteLine(
            "Changing branch2 did not change branch1."
        );

        Console.WriteLine();

        // =====================================
        // STEP 6: Reference Type - Class
        // =====================================

        Console.WriteLine("----- REFERENCE TYPE DEMO -----");

        Book book1 = new Book(
            "C# Basics",
            "Alice"
        );

        Book book2 = book1;

        // Change book2
        book2.Title = "Advanced C# Programming";

        Console.WriteLine(
            $"Original Book Title: {book1.Title}"
        );

        Console.WriteLine(
            $"Copied Book Title:   {book2.Title}"
        );

        Console.WriteLine(
            $"Same object? {ReferenceEquals(book1, book2)}"
        );

        Console.WriteLine();

        // =====================================
        // PROGRAM FINISHED
        // =====================================

        Console.WriteLine("======================================");
        Console.WriteLine("          PROGRAM FINISHED");
        Console.WriteLine("======================================");

        Console.ReadKey();
    }
}
