using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iys.Controllers
{
    public class AdminPanelController : BaseController
    {
        //
        // GET: /AdminPanel/
        public ActionResult Index()
        {
            return View(getCourse());
        }

        public ActionResult MasterDetail()
        {
            return View(getCourse());
        }
        public ActionResult MasterDetailMasterPartial()
        {
            return PartialView("MasterDetailMasterPartial",getCourse());
        }
        public ActionResult MasterDetailDetailPartial(string customerID)
        {
            ViewData["CustomerID"] = customerID;
            return PartialView("MasterDetailDetailPartial", getChapter(Convert.ToInt32(customerID)));
        }
	}
}