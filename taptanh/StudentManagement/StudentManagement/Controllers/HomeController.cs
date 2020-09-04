 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                FullName = "Carrick",
                DoB = "2000/12/25",
                Avatar = "~/Images/logo.png"
            };
            return View(student);
        }
    }
}
