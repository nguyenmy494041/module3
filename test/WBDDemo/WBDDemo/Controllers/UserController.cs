using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WBDDemo.Models;
using WBDDemo.ViewModels;

namespace WBDDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmployeeRepository employeeRepository;

        public UserController(UserManager<ApplicationUser> userManager,
                                IEmployeeRepository employeeRepository
                )
        {
            this.userManager = userManager;
            this.employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var users = userManager.Users;
            var model = users.Select(user => new UserIndexViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
                Address = user.Address,
                City = user.City

            });
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserCreateViewModel model)
        {
                       return View(model);
        }
    }
}
