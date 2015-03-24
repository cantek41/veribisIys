using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.ModelProject
{
    public class COURSE
    {
       
        [Key]
        public int COURSE_CODE { get; set; }
        public string COURSE_NAME { get; set; }
       
        public int TYPE { get; set; }
        public int? GROUP_CODE { get; set; }
        public int CATEGORY { get; set; }
        public int RES_CODE { get; set; }
        public int ORDER_BY { get; set; }
        public bool VISIBLE { get; set; }
        public int? DES_01 { get; set; }
        public string DES_02 { get; set; }
        public string DES_03 { get; set; }
        public int ROW_NO { get; set; }
        public int CREATE_USER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int LAST_UPDATE_USER { get; set; }

      
    }
}