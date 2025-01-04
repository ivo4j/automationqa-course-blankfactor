using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.AdvancedLibraryMS.Abstracts
{
    public abstract class LibraryItem : IBorrowable
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; private set; }
        public string Borrower { get; private set; }
        public DateTime DueDate { get; private set; }

        protected LibraryItem(string title)
        {
            Title = title;
            IsBorrowed = false;
        }

        public void Borrow(string borrower, DateTime dueDate)
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"'{Title}' is already borrowed.");
                return;
            }

            IsBorrowed = true;
            Borrower = borrower;
            DueDate = dueDate;
            OnBorrow();
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"'{Title}' is not currently borrowed.");
                return;
            }

            IsBorrowed = false;
            Borrower = null;
            DueDate = default;
            Console.WriteLine($"'{Title}' has been returned.");
        }

        public void CheckStatus()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"Title: {Title}, Borrowed by {Borrower}, Due on {DueDate.ToShortDateString()}.");
            }
            else
            {
                Console.WriteLine($"Title: {Title}, Available for borrowing.");
            }
        }

        public void ExtendDueDate(int days)
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"Cannot extend due date for '{Title}' as it is not borrowed.");
                return;
            }

            DueDate = DueDate.AddDays(days);
            Console.WriteLine($"Due date for '{Title}' has been extended by {days} days.");
        }

        protected abstract void OnBorrow();
    }
}
