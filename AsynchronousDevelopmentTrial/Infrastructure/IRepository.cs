using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsynchronousDevelopmentTrial.Models;

namespace AsynchronousDevelopmentTrial.Infrastructure
{
    /// <summary>
    /// Repository to add update and delete items from the database
    /// </summary>
    public interface IRepository
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Member> Members { get; }
    }
}