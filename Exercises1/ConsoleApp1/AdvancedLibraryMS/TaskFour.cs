using EncapsulationAbstractionApp9.AdvancedLibraryMS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.AdvancedLibraryMS
{
    internal class TaskFour
    {
        public void TaskFourStart()
        {
            List<LibraryItem> library = new List<LibraryItem>
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald"),
                new Book("1984", "George Orwell"),
                new Magazine("National Geographic", 202),
                new Magazine("TIME", 124)
            };

            Dictionary<string, int> borrowerLimits = new Dictionary<string, int>();

            void BorrowItem(string borrower, LibraryItem item, DateTime dueDate)
            {
                if (!borrowerLimits.ContainsKey(borrower))
                    borrowerLimits[borrower] = 0;

                if (borrowerLimits[borrower] >= 3)
                {
                    Console.WriteLine($"{borrower} has reached the borrowing limit of 3 items.");
                    return;
                }

                item.Borrow(borrower, dueDate);
                if (item.IsBorrowed) borrowerLimits[borrower]++;
            }

            void ReturnItem(string borrower, LibraryItem item)
            {
                if (item.IsBorrowed && item.Borrower == borrower)
                {
                    item.Return();
                    borrowerLimits[borrower]--;
                }
                else
                {
                    Console.WriteLine($"{borrower} cannot return '{item.Title}' as they did not borrow it.");
                }
            }

            BorrowItem("Alice", library[0], DateTime.Now.AddDays(7)); // Borrow a book
            BorrowItem("Alice", library[1], DateTime.Now.AddDays(10)); // Borrow another book
            BorrowItem("Alice", library[2], DateTime.Now.AddDays(5)); // Borrow a magazine
            BorrowItem("Alice", library[3], DateTime.Now.AddDays(3)); // Exceeding limit

            Console.WriteLine("\nLibrary Status:");
            foreach (var item in library)
                item.CheckStatus();

            Console.WriteLine("\nReturning an item:");
            ReturnItem("Alice", library[0]);

            Console.WriteLine("\nLibrary Status After Return:");
            foreach (var item in library)
                item.CheckStatus();
        }
    }
}

