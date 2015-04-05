using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.ModelProject
{
    public class CHAPTER
    {

        [Key]
        public int CHAPTER_CODE { get; set; }
        public string CHAPTER_NAME { get; set; }
        public int? COURSE_CODE { get; set; }
        public int? RES_CODE { get; set; }
        public int? ORDER_BY { get; set; }
        public bool? VISIBLE { get; set; }
        public int? ROW_NO { get; set; }
        public string DURATION { get; set; }
        public int? CREATE_USER { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public int? LAST_UPDATE_USER { get; set; }
    }
}