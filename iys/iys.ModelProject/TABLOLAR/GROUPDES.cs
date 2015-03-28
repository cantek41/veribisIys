using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iys.ModelProject.TABLOLAR
{
    public class GROUPDES
    {
        [Key]
        public int CODE { get; set; }
        public string EXP_TR { get; set; }
        public string EXP_EN { get; set; }
        public string EXP_GR { get; set; }
        public int? UPPER_EXIST { get; set; }
        public string UPPER_CAPTION { get; set; }
        public int? UPPER_FIH_NO { get; set; }
        public int? UPPER_GROUP_CODE { get; set; }
        public int? MTYPE { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public int? CREATE_USER { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public int? LAST_UPDATE_USER { get; set; }
    }
}
