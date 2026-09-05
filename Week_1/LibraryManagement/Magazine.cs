using System;

namespace LibraryManagement
{
    public class Magazine : LibraryItemBase
    {
        private int _issueNumber;
        public int IssueNumber
        {
            get { return _issueNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Issue number must be a positive integer.");
                }
                _issueNumber = value;
            }
        }
        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }
        public override void Describe()
        {
            Console.WriteLine($"Magazine: {Title}, Issue Number: {IssueNumber}");
        }
    }
}
