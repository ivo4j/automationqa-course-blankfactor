using EncapsulationAbstractionApp9.AdvancedLibraryMS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.AdvancedLibraryMS
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        protected override void OnBorrow()
        {
            Console.WriteLine($"Book '{Title}' by {Author} borrowed by {Borrower}, due on {DueDate.ToShortDateString()}.");
        }
    }
}
