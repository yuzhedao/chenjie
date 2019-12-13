using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClassCoustmer.Models;

namespace ClassCoustmer.Controllers
{
    public class CourseSubejectsController : Controller
    {
        private Cousemodle db = new Cousemodle();

        // GET: CourseSubejects
        public ActionResult Index()
        {
            return View(db.CourseSubeject.ToList());
        }

        // GET: CourseSubejects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSubeject courseSubeject = db.CourseSubeject.Find(id);
            if (courseSubeject == null)
            {
                return HttpNotFound();
            }
            return View(courseSubeject);
        }

        // GET: CourseSubejects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseSubejects/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name")] CourseSubeject courseSubeject)
        {
            if (ModelState.IsValid)
            {
                db.CourseSubeject.Add(courseSubeject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseSubeject);
        }

        // GET: CourseSubejects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSubeject courseSubeject = db.CourseSubeject.Find(id);
            if (courseSubeject == null)
            {
                return HttpNotFound();
            }
            return View(courseSubeject);
        }

        // POST: CourseSubejects/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name")] CourseSubeject courseSubeject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseSubeject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseSubeject);
        }

        // GET: CourseSubejects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSubeject courseSubeject = db.CourseSubeject.Find(id);
            if (courseSubeject == null)
            {
                return HttpNotFound();
            }
            return View(courseSubeject);
        }

        // POST: CourseSubejects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseSubeject courseSubeject = db.CourseSubeject.Find(id);
            db.CourseSubeject.Remove(courseSubeject);
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
