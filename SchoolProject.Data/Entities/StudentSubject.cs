using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int StudSubId { get; set; }
        public int StudId { get; set; }
        public int SubtId { get; set; }
        [ForeignKey("StudId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubId")]
        public virtual Subjects Subject { get; set; }

    }
}
