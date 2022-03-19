using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpClientFactory factory;

        public LoginController(IUnitOfWork unitOfWork, IHttpClientFactory factory)
        {
            this.unitOfWork = unitOfWork;
            this.factory = factory;
        }

        public class A
        {
            public int MyProperty { get; set; }
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            //var client = factory.CreateClient();

            //var json = JsonSerializer.Serialize(new A { MyProperty = 48720 });
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            //client.DefaultRequestHeaders.Add("Accept", "application/json");

            //var response = await client.PostAsync("https://localhost:5003/api/v1/course/get", content);
            
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

            if (person != null && person is Teacher)
            {
            List<Claim> identity = new List<Claim>();
            identity.Add(new Claim(ClaimTypes.Name, person.FirstName));
            identity.Add(new Claim(ClaimTypes.NameIdentifier, person.Username));
            identity.Add(new Claim("Id", person.PersonId.ToString()));
            identity.Add(new Claim(ClaimTypes.Role, person.GetType().ToString()));
            Dictionary<string, string> dict = identity.ToDictionary(i => i.Type, i => i.Value);
                HttpContext.Session.Set("user", JsonSerializer.SerializeToUtf8Bytes(dict, typeof(Dictionary<string, string>), new JsonSerializerOptions { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve }));
                return RedirectToAction("Index", "Student");
            }
            ModelState.AddModelError(string.Empty, "Wrong credentials!!");


            return View();
        }

     
    }
}
