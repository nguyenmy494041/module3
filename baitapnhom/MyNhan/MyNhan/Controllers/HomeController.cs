using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyNhan.Models;

namespace MyNhan.Controllers
{
    public class HomeController : Controller
    {
        //private readonly UserManager<TaiKhoan> userManager;
        //private readonly SignInManager<TaiKhoan> signInManager;

        ////private readonly ILogger<HomeController> _logger;

        ////public HomeController(ILogger<HomeController> logger)
        ////{
        ////    _logger = logger;
        ////}
        //public HomeController(UserManager<TaiKhoan> userManager, SignInManager<TaiKhoan> signInManager)
        //{
        //    this.userManager = userManager;
        //    this.signInManager = signInManager;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult TaoTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            //if (ModelState.IsValid)
            //{
            //    userManager.CreateAsync   (taiKhoan);
                
            //}
            return View();
        }
    }
}
