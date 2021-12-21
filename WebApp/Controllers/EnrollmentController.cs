using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IUnitOfWork unit;

        public EnrollmentController(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        [HttpGet]
        [LoggedIn]
        public IActionResult EnrollStudent([FromRoute(Name ="id")]int studentId)
        {
            var courses = unit.CourseRepository.GetAll();

            EnrollmentsViewModel model = new EnrollmentsViewModel();
            model.Courses = courses.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
            var student =(Domain.Student) unit.StudentRepository.SearchById(new Domain.Person { PersonId = studentId });
            model.Student.StudentName = student.FirstName+" "+student.LastName;
            model.Student.StudentId = student.PersonId;
            model.Student.StudentIndex = student.EnrollmentYear + "/" + student.EnrollmentNumber;
            return View(model);
        }

        [HttpPost]
        public IActionResult EnrollStudent([FromForm(Name ="Student")] StudentViewModel student)
        {
            if (!ModelState.IsValid)
            {
               return EnrollStudent(2);
            }
            var courses = unit.CourseRepository.GetAll();
            EnrollmentsViewModel model = new EnrollmentsViewModel();
            model.Courses = courses.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        
           
            return View(model);
        }
    }
}
