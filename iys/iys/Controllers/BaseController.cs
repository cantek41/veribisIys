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
                username = db.USERDETAILS.Where(x => x.NICK_NAME == userId).Select(x => x.USER_CODE).SingleOrDefault();

            }
            return username;
        }
        /// <summary>
        /// tüm Dersleri getirir
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> getCourse()
        {
            using (iysContext db = new iysContext())
            {
                return (from d in db.COURSES
                        select new { Key = d.COURSE_CODE, Value = d.COURSE_NAME }).ToDictionary(t => t.Key, t => t.Value);
            }
        }

        /// <summary>
        /// seçilen dersin bölümlerini getirir
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> getChapter(int course)
        {
            using (iysContext db = new iysContext())
            {
                return (from d in db.CHAPTERS
                        where d.COURSE_CODE == course
                        select new { Key = d.CHAPTER_CODE, Value = d.CHAPTER_NAME }).ToDictionary(t => t.Key, t => t.Value);
            }
        }

        /// <summary>
        /// seçilen soruyu getiri
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> getQuestions(int LESSON_CODE)
        {
            using (iysContext db = new iysContext())
            {
                return (from d in db.QUESTIONS
                        where d.LESSON_CODE == LESSON_CODE
                        select new { Key = d.QUESTION_CODE, Value = d.DESCRIPTION }).ToDictionary(t => t.Key, t => t.Value);
            }
        }
        /// <summary>
        /// seçilen soruyu getiri
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> getQuestions()
        {
            using (iysContext db = new iysContext())
            {
                return (from d in db.QUESTIONS
                        select new { Key = d.QUESTION_CODE, Value = d.DESCRIPTION }).ToDictionary(t => t.Key, t => t.Value);
            }
        }
    }
}