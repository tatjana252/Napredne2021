using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<Student> model = unitOfWork.StudentRepository.GetAll().OfType<Student>().ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            CreateStudentViewModel model = new CreateStudentViewModel();
            var programs = unitOfWork.StudyProgramRepository.GetAll();
            model.StudyPrograms = programs.Select(p => new SelectListItem(p.Name, p.SpId.ToString())).ToList();

            //List<SelectListItem> lista = new List<SelectListItem>();    
            //foreach (var program in programs)
            //{
            //    lista.Add(new SelectListItem(program.Name, program.SpId.ToString()));
            //}

            return View(model);
        }

        [HttpPost]
        public IActionResult Create([FromForm]CreateStudentViewModel student)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            var pass = $"{student.FirstName[0]}{student.LastName[0]}{student.EnrollmentYear}{student.EnrollmentNumber}";

            unitOfWork.StudentRepository.Add(new Student { 
                FirstName = student.FirstName, 
                LastName = student.LastName, 
                EnrollmentYear = student.EnrollmentYear,
                Username = student.UserName,
                EnrollmentNumber = student.EnrollmentNumber, 
                SpId = student.StudyProgramId, 
                Password = pass });
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            CreateStudentViewModel model = new CreateStudentViewModel();

            Student s = (Student)unitOfWork.StudentRepository.SearchById(new Person { PersonId = id });

            model.FirstName = s.FirstName;
            model.LastName = s.LastName;
            model.EnrollmentYear = s.EnrollmentYear;
            model.EnrollmentNumber = s.EnrollmentNumber;
            model.UserName = s.Username;
            model.StudyProgramId = s.SpId;
            var programs = unitOfWork.StudyProgramRepository.GetAll();
            model.StudyPrograms = programs.Select(p => new SelectListItem(p.Name, p.SpId.ToString())).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, CreateStudentViewModel student)
        {
            unitOfWork.StudentRepository.Update(new Student
            {
                PersonId = id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Username = student.UserName,
                EnrollmentYear = student.EnrollmentYear,
                EnrollmentNumber = student.EnrollmentNumber,
                SpId = student.StudyProgramId,
            });
            unitOfWork.Save();

            return RedirectToAction("Index");
        }
    }
}
