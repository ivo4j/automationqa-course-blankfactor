using EncapsulationAbstractionApp9.AdvancedLibraryMS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.AdvancedLibraryMS
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        protected override void OnBorrow()
        {
            Console.WriteLine($"Magazine '{Title}' (Issue {IssueNumber}) borrowed by {Borrower}, due on {DueDate.ToShortDateString()}.");
        }
    }
}
