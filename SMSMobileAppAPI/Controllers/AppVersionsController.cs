using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    public class AppVersionsController : Controller
    {
        private webSchoolContext db = new webSchoolContext();
         
        // GET: AppVersions
        public ActionResult Index()
        {
            return View(db.tblAppVersions.ToList());
        }

        // GET: AppVersions/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppVersion tblAppVersion = db.tblAppVersions.Find(id);
            if (tblAppVersion == null)
            {
                return HttpNotFound();
            }
            return View(tblAppVersion);
        }

        // GET: AppVersions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppVersions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VersionId,BuidDate,Version,UpdateMessage,Notes")] tblAppVersion tblAppVersion)
        {
            
            if (ModelState.IsValid)
            {
                db.tblAppVersions.Add(tblAppVersion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblAppVersion);
        }

        // GET: AppVersions/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppVersion tblAppVersion = db.tblAppVersions.Find(id);
            if (tblAppVersion == null)
            {
                return HttpNotFound();
            }
            return View(tblAppVersion);
        }

        // POST: AppVersions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VersionId,BuidDate,Version,UpdateMessage,Notes")] tblAppVersion tblAppVersion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblAppVersion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblAppVersion);
        }

        // GET: AppVersions/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppVersion tblAppVersion = db.tblAppVersions.Find(id);
            if (tblAppVersion == null)
            {
                return HttpNotFound();
            }
            return View(tblAppVersion);
        }

        // POST: AppVersions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tblAppVersion tblAppVersion = db.tblAppVersions.Find(id);
            db.tblAppVersions.Remove(tblAppVersion);
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