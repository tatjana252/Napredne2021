using AspMVC.Models;
using AspMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITest test;

        public HomeController(ITest test)
        {
            this.test = test;
        }

        public IActionResult Index()
        {
            var res = test.Print();
            return View("Index", res);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
