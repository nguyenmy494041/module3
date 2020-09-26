using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaiKiemTraLan3.Models;
using BaiKiemTraLan3.Servicesss;
using BaiKiemTraLan3.Models.Entitiesss;

namespace BaiKiemTraLan3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBanhService banhService;

        public HomeController(ILogger<HomeController> logger,IBanhService banhService)
        {
            _logger = logger;
            this.banhService = banhService;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





        public IActionResult Index()
        {
            var dat = banhService.LayDanhSachCacLoaiBanh();
            return View(dat);
        }

        [Route("/Home/XemChiTiet/{matheloai}")]
        public IActionResult XemChiTiet(int matheloai)
        {
            ViewBag.matheloai = new Cake() { MaTheLoai = matheloai };
            var data = banhService.LayTenBanhTheoLoai(matheloai);
            return View(data);
        }


        [HttpGet]
        [Route("/Home/ThemMoiBanh/{matheloai}")]
        public IActionResult ThemMoiBanh(int matheloai)
        {
            ViewBag.malop = new Cake() { MaTheLoai = matheloai };
            return View();
        }
        [HttpPost]
        public IActionResult ThemMoiBanh(Cake banh)
        {
            if (ModelState.IsValid)
            {
                var result = banhService.ThemMoiBanh(banh);
                if (result > 0)
                {
                    return RedirectToAction("XemChiTiet", "Home", new { matheloai = banh.MaTheLoai });
                }
            }           
            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }


        [HttpGet]
        [Route("/Home/ThayDoiThongTin/{mabanh}")]
        public IActionResult ThayDoiThongTin(int mabanh)
        {
            var hocvien = banhService.LayVe1Banh(mabanh);
            return View(hocvien);
        }
        [HttpPost]
        public IActionResult ThayDoiThongTin(Cake banh)
        {
            if (ModelState.IsValid)
            {
                var result = banhService.ThayDoiThongTinBanh(banh);
                if (result != null)
                {
                    return RedirectToAction("XemChiTiet", "Home", new { matheloai = result.MaTheLoai });
                }
            }

            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }


        [Route("/Home/XemChiTietMotBanh/{mabanh}")]
        public IActionResult XemChiTietMotBanh(int mabanh)
        {
            var banh = banhService.LayVe1Banh(mabanh);
            return View(banh);
        }



        [Route("/Home/XoaBanh/{mabanh}")]
        public IActionResult XoaBanh(int mabanh)
        {
            var xoa = banhService.XoaBanh(mabanh);
            return RedirectToAction("XemChiTiet", "Home", new { matheloai = xoa.MaTheLoai });


        }

    }
}
