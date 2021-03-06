﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public EmployeeController()
        {
            // should this contain anything?
        }

        public ActionResult Index()
        {
            var CollectionRoute = db.Employees.Include(m => m.CustomerModel).ToList();
            return View(CollectionRoute);
        }

        public ActionResult Sort()
        {
            var TodaysPickUps = db.Customers.Where(m => m.WeeklyPickUpDay == DateTime.Now.DayOfWeek.ToString()).ToList();
            var customerAddresses = db.Employees.Include(m => m.CustomerAddress).ToList();
            return View("Employee", TodaysPickUps);
        }

        public ActionResult Create(CustomerModel Customer)
        {
            var CurrentBalance = ((Customer.CollectionCharge * Customer.PickUpsThisMonth) - Customer.PaymentAmount);
            return View();
        }

      //public PayPal()
      //{

      //}
    }
}
