using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsynchronousDevelopmentTrial.Models;

namespace AsynchronousDevelopmentTrial.Infrastructure
{
    public class MyTestRepo : IRepository
    {
        IEnumerable<Item> IRepository.Items
        {
            get
            {
                return new List<Item>()
                {
                    new Item() { Title = "TestItem1", Year = 1989, ItemID = 1, Borrower = new Member() { Name = "AAA", MemberID = 2 }},
                    new Item() { Title = "TestItem2", Year = 1989, ItemID = 2, Borrower = new Member() { Name = "AAA", MemberID = 2 }}
                };
            }
        }

        public IEnumerable<Member> Members
        {
            get
            {
                return new List<Member>()
                {
                    new Member() { Name = "AAA", MemberID = 2 },
                    new Member() { Name = "AAA", MemberID = 2 }
                };
            }
        }
    }
}