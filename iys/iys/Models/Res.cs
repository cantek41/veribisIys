using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iys.Models;


namespace iys.Models
{
    public class Res
    {
        public static string languege { get; set; }
        public static string resGetir(int resId)
        {

            string str = null;
            using (iys.ModelProject.iysContext db = new iys.ModelProject.iysContext())
            {

                switch (languege)
                {
                    case "TR":
                        str = (from icerik in db.RESS
                               where icerik.R_ID == resId
                               select icerik.TR).FirstOrDefault().ToString();
                        break;
                    case "EN":
                        str = (from icerik in db.RESS
                               where icerik.R_ID == resId
                               select icerik.EN).FirstOrDefault().ToString();
                        break;
                    default:
                        str = (from icerik in db.RESS
                               where icerik.R_ID == resId
                               select icerik.TR).FirstOrDefault().ToString();
                        break;
                }
            }
            return str;
        }
    }
}