using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class StudyProgramRepository : IStudyProgramRepository
    {
        private readonly StudentContext context;

        public StudyProgramRepository(StudentContext context)
        {
            this.context = context;
        }
        public void Add(StudyProgram entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StudyProgram entity)
        {
            throw new NotImplementedException();
        }

        public List<StudyProgram> GetAll()
        {
            return context.StudyPrograms.ToList();
        }

        public List<StudyProgram> SearchBy(Expression<Func<StudyProgram, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public StudyProgram SearchById(StudyProgram entity)
        {
            throw new NotImplementedException();
        }

        public void Update(StudyProgram entity)
        {
            throw new NotImplementedException();
        }
    }
}
