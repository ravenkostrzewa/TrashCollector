﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel customerModel = db.Customers.Find(id);
            if (customerModel == null)
            {
                return HttpNotFound();
            }
            return View(customerModel);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,CustomerEmail,CustomerPassword,CustomerName,CustomerStreet,CustomerCityState,CustomerZip,WeeklyPickUpDay,CancelWeeklyPickUp,RescheduleWeeklyPickUp,CollectionCharge,MonthlyBill,PaymentAmount,CurrentBalance")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerModel);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel customerModel = db.Customers.Find(id);
            if (customerModel == null)
            {
                return HttpNotFound();
            }
            return View(customerModel);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,CustomerEmail,CustomerPassword,CustomerName,CollectionCharge,CustomerStreet,CustomerCityState,CustomerZip,WeeklyPickUpDay,CancelWeeklyPickUp,RescheduleWeeklyPickUp,MonthlyBill,PaymentAmount,CurrentBalance")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerModel);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel customerModel = db.Customers.Find(id);
            if (customerModel == null)
            {
                return HttpNotFound();
            }
            return View(customerModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerModel customerModel = db.Customers.Find(id);
            db.Customers.Remove(customerModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}