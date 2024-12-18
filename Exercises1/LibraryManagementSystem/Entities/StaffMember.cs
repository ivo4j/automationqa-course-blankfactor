using LibraryManagementSystem.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class StaffMember : Member
    {
        
        public StaffMember() : base()
        { 
            BarrowingLimit = 10;
        }
        
        
    }
}
