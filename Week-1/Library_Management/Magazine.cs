public class Magazine : LibraryItemBase
{
    public int IssueNumber { get; set; }

    public Magazine(string title, int issueNumber) : base(title)
    {
        IssueNumber = issueNumber;
        ItemType = "Magazine";
    }

    public override void Describe()
    {
        Console.WriteLine();
        Console.WriteLine("MAGAZINE~~ ");
        Console.WriteLine();
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Issue Number: " + IssueNumber);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}