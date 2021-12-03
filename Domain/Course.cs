using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();
        public List<Exam> Exams { get; set; }
    }
}
