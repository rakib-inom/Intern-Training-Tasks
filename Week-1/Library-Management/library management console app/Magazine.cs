namespace LibraryManagementConsoleApp;

public class Magazine : LibraryItemBase
{
    private int _issueNumber;

    public Magazine(string title, int issueNumber)
        : base(title, "Magazine")
    {
        IssueNumber = issueNumber;
    }

    public int IssueNumber
    {
        get
        {
            return _issueNumber;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Issue number must be greater than 0."
                );
            }

            _issueNumber = value;
        }
    }

    public override string Describe()
    {
        return $"Magazine: {Title} | Issue: {IssueNumber} | Available: {IsAvailable}";
    }
}
