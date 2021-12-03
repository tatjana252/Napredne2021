using DataAccessLayer.Implementations;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentContext context;

        public UnitOfWork(StudentContext context)
        {
            this.context = context;
            CourseRepository = new CourseRepository(context);
            ExamRepository = new ExamRepository(context);
            PersonRepository = new PersonRepository(context);
            StudentRepository = new StudentRepository(context);
            StudyProgramRepository = new StudyProgramRepository(context);
        }
        public ICourseRepository CourseRepository { get; set; } 
        public IExamRepository ExamRepository { get; set; }
        public IPersonRepository PersonRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }
        public IStudyProgramRepository StudyProgramRepository { get; set; }
        public ITeacherRepository TeacherRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
