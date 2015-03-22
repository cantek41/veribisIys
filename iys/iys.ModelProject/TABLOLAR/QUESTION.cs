using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.ModelProject
{
    public class QUESTION
    {
        [Key]
        public int QUESTION_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public int RES_CODE { get; set; }
        public int COURSE_CODE { get; set; }
        public int CHAPTER_CODE { get; set; }
        public int LESSON_CODE { get; set; }
        public int DOCUMENT_CODE { get; set; }
        public int ROW_NO { get; set; }
        public int LEVEL { get; set; }
        public int QUESTION_TYPE { get; set; }
        public int CREATE_USER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int LAST_UPDATE_USER { get; set; }
    }
}