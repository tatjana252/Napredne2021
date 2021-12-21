using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly IUnitOfWork unit;

        public CourseController(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        // GET: CourseController
        public ActionResult CoursePartial([FromQuery(Name = "courseid")] int id, [FromQuery(Name = "sn")] int sn)
        {
            var course = unit.CourseRepository.SearchById(new Domain.Course { Id = id });
            CourseViewModel model = new CourseViewModel();
            model.Id = course.Id;
            model.Name = course.Name;
            model.Espb = 6;

            ViewBag.SerialNumber = sn;


            return PartialView(model);
        }

      
    }
}
