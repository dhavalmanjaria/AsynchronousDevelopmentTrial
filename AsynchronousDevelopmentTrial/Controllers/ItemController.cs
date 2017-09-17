using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsynchronousDevelopmentTrial.Models;
using AsynchronousDevelopmentTrial.Infrastructure;
using System.Diagnostics;

namespace AsynchronousDevelopmentTrial.Controllers
{
    public class ItemController : Controller
    {

        private IRepository repository;

        public ItemController(IRepository _repository)
        {
            this.repository = _repository;
        }

        // GET: Item
        /// <summary>
        /// Lists Items
        /// </summary>
        /// <returns>List<> of Items</returns>
        public ActionResult Index()
        {
            IEnumerable<Item> model = repository.Items;
            if (model == null)
            {
                Debug.WriteLine(repository == null ? "REPO IS NULL" : "REPO IS FINE");
            }
            return View(model);
        }
    }
}