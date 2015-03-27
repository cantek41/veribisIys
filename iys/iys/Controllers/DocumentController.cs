using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iys.ModelProject;
using DevExpress.Web.Mvc;

namespace iys.Controllers
{
    public class DocumentController : BaseController
    {
        //
        // GET: /Document/
        public ActionResult Index()
        {
            ViewData["COURSE_CODE"] = getCourse();
            ViewData["CHAPTER_CODE"] = getChapter(0);
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(DOCUMENT document)
        {
            //var fileName = Path.GetFileName(file.FileName);
            //var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
            //file.SaveAs(path);
            using(iysContext db=new iysContext())
            {
                db.DOCUMENTS.Add(document);
                db.SaveChanges();
            }
            return View();
        }

        iys.ModelProject.iysContext db = new iys.ModelProject.iysContext();

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            var model = db.DOCUMENTS;
            return PartialView("_GridView1Partial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew(iys.ModelProject.DOCUMENT item)
        {
            var model = db.DOCUMENTS;
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
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate(iys.ModelProject.DOCUMENT item)
        {
            var model = db.DOCUMENTS;
            //if (ModelState.IsValid)
            //{
                try
                {
                    //item.DOCUMENT_CODE =
                    //item.DOCUMENT_NAME =
                    item.RES_CODE = 0;
                    // item.COURSE_CODE = 0;
                    //item.CHAPTER_CODE =
                    //item.LESSON_CODE =
                    item.ROW_NO = 0;
                    //item.DOCUMENT_TYPE =
                    //item.PATH =
                    //item.LINK_TYPE =
                    //item.DURATION =
                    item.PRIORITY = 0;
                    item.ROW_ORDER_NO = 0;
                    item.VISIBLE = true;
                    item.CREATE_USER = getCurrentUserName();
                    item.CREATE_DATE = DateTime.Now;
                    item.LAST_UPDATE = DateTime.Now;
                    item.LAST_UPDATE_USER = getCurrentUserName();

                    model.Add(item);
                    db.SaveChanges();


                    var modelItem = model.FirstOrDefault(it => it.DOCUMENT_CODE == item.DOCUMENT_CODE);
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
            //}
            //else
            //    ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.Int32 DOCUMENT_CODE)
        {
            var model = db.DOCUMENTS;
            if (DOCUMENT_CODE >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.DOCUMENT_CODE == DOCUMENT_CODE);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridView1Partial", model.ToList());
        }

        public ActionResult PartialViewChapterCombo(int COURSE_CODE)
        {
          //  MVCxComboBox cmb = (MVCxComboBox)sender;
            int courseID = COURSE_CODE;// Convert.ToInt32(cmb.SelectedItem.Value);
            //int courseID = (Request.Params["COURSE_CODE"] != null) ? int.Parse(Request.Params["COURSE_CODE"]) : -1;
            return PartialView(getChapter(courseID));
        }
	}
}