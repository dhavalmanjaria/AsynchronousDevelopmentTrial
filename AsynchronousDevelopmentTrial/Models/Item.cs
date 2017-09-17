using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsynchronousDevelopmentTrial.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Member Borrower { get; set; }
    }

    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public List<Item> BorrowedItems { get; set; }
    }
}