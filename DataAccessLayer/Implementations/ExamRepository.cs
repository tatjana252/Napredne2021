using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class ExamRepository : IExamRepository
    {
        private readonly StudentContext context;

        public ExamRepository(StudentContext context)
        {
            this.context = context;
        }


        public void Add(Exam entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Exam entity)
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Exam> SearchBy(Expression<Func<Exam, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Exam SearchById(Exam entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Exam entity)
        {
            throw new NotImplementedException();
        }
    }
}
