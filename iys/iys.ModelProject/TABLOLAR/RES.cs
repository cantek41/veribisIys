using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iys.ModelProject.TABLOLAR
{
    public class RES
    {
        [Key]
        public int R_ID { get; set; }
        public string TR { get; set; }
        public string EN { get; set; }
        public string GR { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public int? CREATE_USER { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public int? LAST_UPDATE_USER { get; set; }
    }
}
