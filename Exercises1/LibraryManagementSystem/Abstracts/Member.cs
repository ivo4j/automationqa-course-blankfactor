using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Abstracts
{
    public abstract class Member
    {

        private string _name;
        private int _memberId;
        private string _membershipType;
        private int _borrowingLimit;

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected int MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        protected string MembershipType
        {
            get { return _membershipType; }
            set { _membershipType = value; }
        }

        public int BorrowingLimit 
        {
            get { return _borrowingLimit; }
            set { _borrowingLimit = value; } 
        }

        protected Member(string name, int memberId, string membershipType, int borrowingLimit)
        {
            Name = name;
            MemberId = memberId;
            MembershipType = membershipType;
            BorrowingLimit = borrowingLimit;
        }
    }
}
