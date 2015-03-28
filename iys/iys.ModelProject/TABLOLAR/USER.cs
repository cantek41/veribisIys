using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iys.ModelProject
{
    public class USER
    {
        [Key]
        public int USER_CODE { get; set; }
        public string ID { get; set; }
        public string NICK_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string SURNAME { get; set; }
        public int? USER_LANGUAGE { get; set; }
        public string MAIL { get; set; }
        public int? ISACTIVE { get; set; }
        public DateTime? STARTDATE { get; set; }
        public DateTime? ENDDATE { get; set; }
        public DateTime? TOTALWORKTIME { get; set; }
        public int? CREATE_USER { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public int? LAST_UPDATE_USER { get; set; }
    }
}
