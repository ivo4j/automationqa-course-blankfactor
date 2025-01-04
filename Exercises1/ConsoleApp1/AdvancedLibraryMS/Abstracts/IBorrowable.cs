using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.AdvancedLibraryMS.Abstracts
{
    public interface IBorrowable
    {
        void Borrow(string borrower, DateTime dueDate);
        void Return();
    }
}
