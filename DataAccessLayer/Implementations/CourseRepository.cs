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
    public class CourseRepository : ICourseRepository
    {
        private readonly StudentContext context;

        public CourseRepository(StudentContext context)
        {
            this.context = context;
        }

        public void Add(Course entity)
        {
            context.Add(entity);
        }

        public void Delete(Course entity)
        {
            context.Remove(entity);
        }

        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public List<Course> SearchBy(Expression<Func<Course, bool>> predicate)
        {
            return context.Courses.Where(predicate).ToList();
        }

        public Course SearchById(Course entity)
        {
            return context.Courses.Single(c => c.Id == entity.Id);
        }

        public void Update(Course entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
