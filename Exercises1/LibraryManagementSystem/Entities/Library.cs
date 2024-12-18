using LibraryManagementSystem.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    internal class Library : LibraryManagement
    {
        public override bool addABook()
        {

            Console.WriteLine("Please enter ");
        }

        public override bool borrowABook()
        {
            throw new NotImplementedException();
        }

        public override bool removeABook()
        {
            throw new NotImplementedException();
        }

        public override bool returnABook()
        {
            throw new NotImplementedException();
        }
    }
}
