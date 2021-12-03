using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student : Person
    {
        public int EnrollmentYear { get; set; }
        public int EnrollmentNumber { get; set; }
        public double Gpa { get; set; }
        public int SpId { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public List<Course> EnrolledCourses { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Transaction> Transactions { get; set; }

        public override string ToString()
        {
            return $"{PersonId} {FirstName} {LastName} {EnrollmentYear}/{EnrollmentNumber} {Gpa} {StudyProgram?.SpId} {StudyProgram?.Name}";
        }
    }
}
