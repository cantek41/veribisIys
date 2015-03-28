using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.ModelProject
{
    public class LESSON
    {
        [Key]
        public int LESSON_CODE { get; set; }
        public string LESSON_NAME { get; set; }
        public int? RES_CODE { get; set; }
        public int? ROW_NO { get; set; }
        public int? COURSE_CODE { get; set; }
        public int? CHAPTER_CODE { get; set; }
        public TimeSpan? DURATION { get; set; }
        public int? CREATE_USER { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public int? LAST_UPDATE_USER { get; set; }
        
    }
}