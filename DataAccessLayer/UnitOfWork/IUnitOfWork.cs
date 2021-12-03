using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICourseRepository CourseRepository { get; set; }
        public IExamRepository ExamRepository { get; set; }
        public IPersonRepository PersonRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }
        public IStudyProgramRepository StudyProgramRepository { get; set; }
        public ITeacherRepository TeacherRepository { get; set; }
        public void Save();
    }
}
