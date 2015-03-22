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
<<<<<<< HEAD
            using (var ctx = new iysContext())
            {
=======
            //using (var ctx = new iysContext())
            //{
            //    USER us = new USER { ID = "dsf" };
            //    ctx.USERDETAILS.Add(us);
            //    ctx.SaveChanges();
>>>>>>> 8c357da086fa4bb0a7c5cb4e14e4f38a9be7fe91
               
            //}
            return View();
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