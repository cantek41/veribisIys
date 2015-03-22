using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iys.ModelProject;

namespace iys.Controllers
{
    public class ChapterController : BaseController
    {
        private iysContext db = new iysContext();

        // GET: /Chapter/
        public ActionResult Index()
        {
            return View(db.CHAPTERS.ToList());
        }

        // GET: /Chapter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAPTER chapter = db.CHAPTERS.Find(id);
            if (chapter == null)
            {
                return HttpNotFound();
            }
            return View(chapter);
        }

        // GET: /Chapter/Create
        public ActionResult Create()
        {
            ViewData["courses"] = from d in db.COURSES
                                  select new { Key = d.COURSE_CODE, Value = d.COURSE_NAME };
            return View();
        }

        // POST: /Chapter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CHAPTER chapter)
        {
            chapter.CREATE_DATE = DateTime.Now;
            chapter.LAST_UPDATE = DateTime.Now;
            chapter.CREATE_USER = getCurrentUserName();
            chapter.LAST_UPDATE_USER = getCurrentUserName();


            if (ModelState.IsValid)
            {
                db.CHAPTERS.Add(chapter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chapter);
        }

        // GET: /Chapter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAPTER chapter = db.CHAPTERS.Find(id);
            if (chapter == null)
            {
                return HttpNotFound();
            }
            return View(chapter);
        }

        // POST: /Chapter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( CHAPTER chapter)
        {
            chapter.CREATE_DATE = DateTime.Now;
            chapter.LAST_UPDATE = DateTime.Now;
            chapter.CREATE_USER = getCurrentUserName();
            chapter.LAST_UPDATE_USER = getCurrentUserName();

            if (ModelState.IsValid)
            {
                
                db.Entry(chapter).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chapter);
        }

        // GET: /Chapter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAPTER chapter = db.CHAPTERS.Find(id);
            if (chapter == null)
            {
                return HttpNotFound();
            }
            return View(chapter);
        }

        // POST: /Chapter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHAPTER chapter = db.CHAPTERS.Find(id);
            db.CHAPTERS.Remove(chapter);
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
