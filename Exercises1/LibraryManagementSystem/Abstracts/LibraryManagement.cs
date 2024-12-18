using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Abstracts
{
    public abstract class LibraryManagement
    {
        public abstract bool addABook();
        public abstract bool removeABook();

        public abstract bool borrowABook();

        public abstract bool returnABook();


    }
}
