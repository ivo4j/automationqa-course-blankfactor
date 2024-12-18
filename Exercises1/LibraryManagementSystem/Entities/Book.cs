using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    internal class Book
    {
        string _title;
        string _author;
        string _isbn;
        int _availablecopies;
        public Book(string title, string author, string ISBN, int availablecopies)
        {
            _title = title;
            _author = author;
            _isbn = ISBN;
            _availablecopies = availablecopies;
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        int AvailableCopies
        {
            get { return _availablecopies; }
            set { _availablecopies = value; }
        }

        public override string ToString()
        {
            return $"{Title} - {Author} - {ISBN}";
        }

        public static bool ValidateAvailableCopies(int numberOfCopies)
        {
            if (numberOfCopies < 0)
            { return false; }
            else return true;

        }

        public bool BorrowCopy(int copies)
        {
            _availablecopies--;
            return true;
        }

        public bool ReturnBook() 
        {
            _availablecopies++;
            return true;
        }
    }
}
