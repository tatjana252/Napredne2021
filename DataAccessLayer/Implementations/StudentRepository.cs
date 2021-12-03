using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext context;

        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }

        public void Add(Person entity)
        {
            context.Add(entity);
        }

        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return context.Students.Include(s => s.StudyProgram).ToList().OfType<Person>().ToList();
        }

        public List<Person> SearchBy(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person SearchById(Person entity)
        {
          return context.Students.Find(entity.PersonId);
        }

        public Person SearchByUsernamePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            context.Update(entity);
        }
    }
}
