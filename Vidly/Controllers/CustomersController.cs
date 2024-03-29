﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Cutomers
        [Route("Customers")]
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = GetCustomers();
            return View(customers);
            
        }

        //[Route("Customers/Details/:id")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Shubham Sharma"},
                new Customer { Id = 2, Name = "Gunjan Singh"}
            };
        }



    }
}