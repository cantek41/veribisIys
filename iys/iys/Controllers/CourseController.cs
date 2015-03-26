using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using iys.Models;

namespace iys.Controllers
{
    public class CourseController : BaseController
    {
        //
        // GET: /Course/
        public ActionResult Index()
        {
            return View();
        }

        iys.ModelProject.iysContext db = new iys.ModelProject.iysContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.COURSES;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] iys.ModelProject.COURSE item)
        {
            
                   
            //if (ModelState.IsValid)
            //{
                try
                {

                    item.CATEGORY = 0;
                    item.RES_CODE = 0;
                    item.TYPE = 0;
                    item.VISIBLE = true;
                    item.ORDER_BY = 0;
                    item.ROW_NO = 0;
                    item.DES_02 = "";
                    item.DES_03 = "";
                    item.CREATE_USER = getCurrentUserName();
                    item.CREATE_DATE = DateTime.Now;
                    item.LAST_UPDATE = DateTime.Now;
                    item.LAST_UPDATE_USER = getCurrentUserName();
                   db.COURSES.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            //}
            //else
            //    ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", db.COURSES.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] iys.ModelProject.COURSE item)
        {
            var model = db.COURSES;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.COURSE_CODE == item.COURSE_CODE);
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
        public ActionResult GridViewPartialDelete(System.Int32 COURSE_CODE)
        {
            var model = db.COURSES;
            if (COURSE_CODE >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.COURSE_CODE == COURSE_CODE);
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




        iys.ModelProject.iysContext db1 = new iys.ModelProject.iysContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial1()
        {
            var model = db1.CHAPTERS;
            return PartialView("_GridViewPartial1", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial1AddNew(iys.ModelProject.CHAPTER item)
        {
            var model = db1.CHAPTERS;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial1", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial1Update(iys.ModelProject.CHAPTER item)
        {
            var model = db1.CHAPTERS;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.CHAPTER_CODE == item.CHAPTER_CODE);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db1.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial1", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial1Delete(System.Int32 CHAPTER_CODE)
        {
            var model = db1.CHAPTERS;
            if (CHAPTER_CODE >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.CHAPTER_CODE == CHAPTER_CODE);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial1", model.ToList());
        }
	}
}