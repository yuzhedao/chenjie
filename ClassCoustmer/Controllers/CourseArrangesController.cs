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
    public class CourseArrangesController : Controller
    {
        private Cousemodle db = new Cousemodle();

        // GET: CourseArranges
        public ActionResult Index()
        {
            return View(db.CourseArrange.ToList());
        }

        // GET: CourseArranges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseArrange courseArrange = db.CourseArrange.Find(id);
            if (courseArrange == null)
            {
                return HttpNotFound();
            }
            return View(courseArrange);
        }

        // GET: CourseArranges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseArranges/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ClassId,CourseSubjectId,TeacherId")] CourseArrange courseArrange)
        {
            if (ModelState.IsValid)
            {
                db.CourseArrange.Add(courseArrange);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseArrange);
        }

        // GET: CourseArranges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseArrange courseArrange = db.CourseArrange.Find(id);
            if (courseArrange == null)
            {
                return HttpNotFound();
            }
            return View(courseArrange);
        }

        // POST: CourseArranges/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ClassId,CourseSubjectId,TeacherId")] CourseArrange courseArrange)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseArrange).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseArrange);
        }

        // GET: CourseArranges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseArrange courseArrange = db.CourseArrange.Find(id);
            if (courseArrange == null)
            {
                return HttpNotFound();
            }
            return View(courseArrange);
        }

        // POST: CourseArranges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseArrange courseArrange = db.CourseArrange.Find(id);
            db.CourseArrange.Remove(courseArrange);
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
