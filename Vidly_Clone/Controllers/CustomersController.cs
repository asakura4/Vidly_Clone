using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Clone.Models;

namespace Vidly_Clone.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = getCustomers();

            if (customers == null)
            {
                return HttpNotFound();
            }

            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);

        }


        private IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" },
            };
        }
    }
}