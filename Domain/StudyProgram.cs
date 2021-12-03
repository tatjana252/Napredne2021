using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //[Table("TStudyProgram")]
    public class StudyProgram
    {
        //[Key]
        public int SpId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{SpId} {Name}";
        }
    }
}
