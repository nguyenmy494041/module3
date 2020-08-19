using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;
using WBDDemo.ViewModels;

namespace WBDDemo.Controllers
{
    public class HomeController:Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment )
        {
            this.employeeRepository = employeeRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public ViewResult Index()
        {
            
            var employee = employeeRepository.Gets();

            return View(employee);
        }
        public ViewResult Details(int? id)
        {
            //ViewBag.Employees = employeeRepository.Get(id);
            var employee = employeeRepository.Get(id.Value);
            if (employee == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);

            }

            var detailviewmodel = new HomeDetailsViewModel()
            {
                Employee = employee,
                TitleName = "Quy do thanh Manchester"
            };
            return View(detailviewmodel);

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Fullname = model.Fullname,
                    Email = model.Email,
                    Department = model.Department
                };
                var fileName = string.Empty;
                if (model.Avata != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}__{model.Avata.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using(var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avata.CopyTo(fs);
                    }
                }
                else
                {
                    fileName= $"no_image.jfif";
                }
                employee.AvatarPath = $"~/images/{fileName}";
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
          
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Employee employee = employeeRepository.Get(id);
            if (employee == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id);

            }
            var empEdit = new HomeEditViewModel()
            {
                Id = employee.Id,
                Fullname = employee.Fullname,
                AvataPath = employee.AvatarPath,
                Department = employee.Department,
                Email = employee.Email
            };
            return View(empEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Fullname = model.Fullname,
                    Email = model.Email,
                    Department = model.Department,
                    Id=model.Id,
                    AvatarPath = model.AvataPath
                };
                var fileName = string.Empty;
                if (model.Avata != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}__{model.Avata.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avata.CopyTo(fs);
                    }
                    employee.AvatarPath = $"~/images/{fileName}";
                }               
                var editItem = employeeRepository.Edit(employee);
                if (editItem != null)
                {
                    return RedirectToAction("Details", "Home", new { id = employee.Id });
                }
            }           
           
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
