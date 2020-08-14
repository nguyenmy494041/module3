using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;

namespace WBDDemo.Controllers
{
    public class HomeController:Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        public ViewResult Index()
        {
            //ViewData
            ViewData["employees"] = employeeRepository.Gets();
            return View();
        }
    }
}
