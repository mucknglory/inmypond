﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pond.Web.Areas.Common.Models;
using Pond.Web.DAL;
using PagedList;
using System.Data.Entity.Infrastructure;

namespace Pond.Web.Areas.Client.Controllers
{
    public class ContactsController : Controller
    {
        private PondDbContext db = new PondDbContext();

        // GET: /Admin/Contacts/
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DescriptionSortParam = String.IsNullOrEmpty(sortOrder) ? "description_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.currentFilter = searchString;

            var Contacts = from s in db.Contacts
                                    select s;

            // filter the data to those items that match the searchString
            if (!String.IsNullOrEmpty(searchString))
            {
                Contacts = Contacts.Where(s => s.Name.Contains(searchString)
                        || s.Description.Contains(searchString));
            }

            // sort by the desired sort order
            switch (sortOrder)
            {
                case "name_desc":
                    Contacts = Contacts.OrderByDescending(s => s.Name);
                    break;

                case "description_desc":
                    Contacts = Contacts.OrderByDescending(s => s.Description);
                    break;
                default:
                    Contacts = Contacts.OrderBy(s => s.Name);
                    break;

            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(Contacts.ToPagedList(pageNumber, pageSize));
        }

        // GET: /Admin/Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCategory serviceCategory = db.Contacts.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }
            return View(serviceCategory);
        }

        // GET: /Admin/Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Admin/Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Description,parentCategoryID")] ServiceCategory serviceCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Contacts.Add(serviceCategory);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                // TODO: Log the error (Uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see youe system administrator.");
            }

            return View(serviceCategory);
        }

        // GET: /Admin/Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCategory serviceCategory = db.Contacts.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }
            return View(serviceCategory);
        }

        // POST: /Admin/Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var serviceCategoryToUpdate = db.Contacts.Find(id);
            if (TryUpdateModel(serviceCategoryToUpdate, "", new string[] { "Name", "Description", "ParentCategoryID" }))
            {
                try
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    // TODO: Log the error (uncomment dex variable name and add a line here to write a log entry
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                }
            }
            return View(serviceCategoryToUpdate);

        }

        // GET: /Admin/Contacts/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists contact your system administrator.";
            }
            ServiceCategory serviceCategory = db.Contacts.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }
            return View(serviceCategory);
        }

        // POST: /Admin/Contacts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ServiceCategory serviceCategory = db.Contacts.Find(id);
                db.Contacts.Remove(serviceCategory);
                db.SaveChanges();
            }
            catch (RetryLimitExceededException /* dex */)
            {
                // TODO: Log the error (uncomment dex variable name and add a line here to write a log entry
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
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
