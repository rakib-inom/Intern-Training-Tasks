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
        console.WriteLine("Magazine");
        console.WriteLine("Title: " + Title);
        console.WriteLine("Issue Number: " + IssueNumber);
        console.WriteLine("Available: " + IsAvailable);
        console.WriteLine();
    }
}