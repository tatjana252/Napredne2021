using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private readonly StudentContext context;

        public PersonRepository(StudentContext context)
        {
            this.context = context;
        }


        public void Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Person> SearchBy(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person SearchById(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person SearchByUsernamePassword(string username, string password)
        {
            return context.Teacher.SingleOrDefault(t => t.Username == username && t.Password == password);
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
