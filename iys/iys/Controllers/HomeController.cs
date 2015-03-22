using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iys.ModelProject;


namespace iys.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var ctx = new iysContext())
            {

                //using (var ctx = new iysContext())
                //{
                //    USER us = new USER { ID = "dsf" };
                //    ctx.USERDETAILS.Add(us);
                //    ctx.SaveChanges();


                //}
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}