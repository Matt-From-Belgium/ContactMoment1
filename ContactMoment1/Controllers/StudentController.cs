using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactMoment1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ContactMoment1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lijst()
        {
            return View();
        }
        public IActionResult zonderLayout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index (PersonVM personVM)
        {
            string naam = personVM.Naam;
            return View();
        }
    }
}