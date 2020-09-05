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
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(UserManager<ApplicationUser> userManager,
                                IEmployeeRepository employeeRepository,
                                SignInManager<ApplicationUser> signInManager
                )
        {
            this.userManager = userManager;
            this.employeeRepository = employeeRepository;
            this.signInManager = signInManager;
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
        public async Task<IActionResult> Create(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = model.Email,
                    UserName = model.Email,
                    City = model.City,
                    Address = model.Address
                };
                var result = await userManager.CreateAsync(user: user, password: model.Password);
                if (result.Succeeded)
                {
                   
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var model = new UserEditViewModel()
                {
                    Address = user.Address,
                    Email = user.Email,
                    City = user.City,
                    UserId=user.Id                    
                };
                return View(model);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var edit = await userManager.FindByIdAsync(model.UserId);
                if (edit!=null)
                {
                    edit.City = model.City;
                    edit.Address = model.Address;
                    edit.Email = model.Email;
                    var result = await userManager.UpdateAsync(edit);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }            
            
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(string id)
        {
            var user =await userManager.FindByIdAsync(id);
            if (user!=null)
            {
                await userManager.DeleteAsync(user);
                return RedirectToAction("Index", "User");
            }         
               
            return RedirectToAction("PageNotFound","Error");
         
        }
    }
}
