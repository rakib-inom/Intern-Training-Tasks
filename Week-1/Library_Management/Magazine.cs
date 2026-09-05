public class magazine : LibraryItemBase
{
    public int IssueNumber { get; set; }

    public magazine(string title, int issueNumber) : base(title)
    {
        IssueNumber = issueNumber;
        itemType = "Magazine";
    }

    public override void describe()
    {
        console.WriteLine("Magazine");
        console.WriteLine("Title: " + Title);
        console.WriteLine("Issue Number: " + IssueNumber);
        console.WriteLine("Available: " + isAvailable);
        console.WriteLine();
    }
}