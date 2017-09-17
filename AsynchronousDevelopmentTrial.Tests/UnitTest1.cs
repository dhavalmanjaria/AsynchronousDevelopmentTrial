using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using AccessionRegisterTDDTrial.Models;
using System.Collections.Generic;
using AsynchronousDevelopmentTrial.Models;
using AsynchronousDevelopmentTrial.Infrastructure;

namespace AsynchronousDevelopmentTrial.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IRepository repo;

        
        // Frontend Tests
        [TestMethod]
        public void Repo_Has_Items()
        {
            Assert.IsNotNull(repo.Items);
        }

        [TestMethod]
        public void Repo_Has_Members()
        {
            Assert.IsNotNull(repo.Members);
        }

        [TestMethod]
        public void Items_Have_Members()
        {
            IRepository repo = new MyTestRepo();
            Item item = repo.Items.First();
            Assert.IsNotNull(item.Borrower);
        }

        [TestMethod]
        public void Items_of_Members()
        {
            Member member = repo.Members.First();
            Assert.IsFalse(member.BorrowedItems.Count > 0);
        }
    }
}
