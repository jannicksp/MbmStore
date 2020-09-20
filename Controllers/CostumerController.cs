using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<string> phoneNumberList = new List<string>();

            var customer01 = new Customer("John", "Doe", "Gade2", "8000", "Aarhus", "20257334");

            var customer02 = new Customer("Jonoas", "Dae", "Gade5", "8000", "Aarhus", "10257334");

            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer01);
            customerList.Add(customer02);

            ViewBag.Customers = Repository.Customers;
            return View();
        }
    }
}