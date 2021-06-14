using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prog7311.Controllers
{
   
    public class EmployeeController : Controller
    {
        private prog7311Entities db = new prog7311Entities();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders(string category)
        {
            IEnumerable<Item> cat = from Item in db.Items where Item.category == category
                                    select Item;
            for () ;

            return View(cat.ToList);
            //category sort
        }

        
    }
}