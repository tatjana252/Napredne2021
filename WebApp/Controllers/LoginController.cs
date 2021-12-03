using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var person = unitOfWork.PersonRepository.SearchByUsernamePassword(login.Username, login.Password);
            if(person != null && person is Teacher)
            {
                return RedirectToAction("Index", "Student");
            }
            ModelState.AddModelError(string.Empty, "Wrong credentials!!");


            return View();
        }
    }
}
