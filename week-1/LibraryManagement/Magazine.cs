namespace LibraryManagement
{
    public class Magazine : LibraryItemBase
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, int issueNumber)
            : base (title)
        {
            IssueNumber = issueNumber;
        }
        public override void Describe()
        {
            Console.WriteLine($"Magazine: {Title},Issue Number:{IssueNumber}");
        }
    }
}
