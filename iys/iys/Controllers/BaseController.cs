using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iys.ModelProject;

namespace iys.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// session daki user bilgilerini getirir
        /// </summary>
        /// <returns>user code</returns>
        public int getCurrentUserName()
        {
            int username = -1;
            using (iysContext db = new iysContext())
            {
                string userId = User.Identity.Name;
                username =db.USERDETAILS.Where(x => x.NICK_NAME == userId).Select(x => x.USER_CODE).SingleOrDefault();
                
            }
            return username;
        }
    }
}