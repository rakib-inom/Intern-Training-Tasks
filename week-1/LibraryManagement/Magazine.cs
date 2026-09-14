using System;

namespace LibraryManagement
{
    public class Magazine : LibraryItemBase
    {
        public int IssueNumber { get; set; }

        public Magazine(string id, string title, int issueNumber)
            : base(id, title)
        {
            IssueNumber = issueNumber;
        }

        public override void Describe()
        {
            Console.WriteLine($"Magazine [ID: {Id}]: {Title}, Issue Number: {IssueNumber}");
        }
    }
}