using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.Models
{
    public class ANSWER_RESULT
    {
        [Key]
        public int USER_CODE { get; set; }
        public int QUESTION_CODE { get; set; }
        public int RESULT_ID { get; set; }
        public string RESULT_TEXT { get; set; }
        public int ACTIVITY_CODE { get; set; }
        public int CREATE_USER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public int LAST_UPDATE_USER { get; set; }
    }
}