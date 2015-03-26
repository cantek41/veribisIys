using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace iys.Controllers
{
    public class LessonController : BaseController
    {
        //
        // GET: /Lesson/
        public ActionResult Index()
        {
            return View();
        }



        iys.ModelProject.iysContext db = new iys.ModelProject.iysContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.LESSONS;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(iys.ModelProject.LESSON item)
        {
            var model = db.LESSONS;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(iys.ModelProject.LESSON item)
        {
            var model = db.LESSONS;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.LESSON_CODE == item.LESSON_CODE);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(System.Int32 LESSON_CODE)
        {
            var model = db.LESSONS;
            if (LESSON_CODE >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.LESSON_CODE == LESSON_CODE);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial", model.ToList());
        }
    }
}
