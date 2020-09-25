using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaiKiemTraLan2.Models;
using BaiKiemTraLan2.Servicess;
using BaiKiemTraLan2.Models.Entitiess;

namespace BaiKiemTraLan2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuanlySach quanlySach;

        public HomeController(ILogger<HomeController> logger, IQuanlySach quanlySach)
        {
            _logger = logger;
            this.quanlySach = quanlySach;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            var danhsach = quanlySach.LayDanhSachCacTheLoai();
            return View(danhsach);
        }


        [Route("/Home/XemChiTiet/{matheloai}")]
        public IActionResult XemChiTiet(int matheloai)
        {
            ViewBag.matheloai = new Book() { MaTheLoai = matheloai };
            var data = quanlySach.LayTenSachTheoLop(matheloai);
            return View(data);
        }


        [HttpGet]
        [Route("/Home/ThemMoiSach/{maloaisach}")]
        public IActionResult ThemMoiSach(int maloaisach)
        {
            ViewBag.malop = new Book() { MaTheLoai = maloaisach };
            return View();
        }
        [HttpPost]
        public IActionResult ThemMoiSach(Book sach)
        {
            var result = quanlySach.ThemMoiSach(sach);
            if (result > 0)
            {
                return RedirectToAction("XemChiTiet", "Home", new { matheloai = sach.MaTheLoai });
            }
            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }



        [Route("/Home/XoaSach/{masach}")]
        public IActionResult XoaSach(int masach)
        {
            var xoa = quanlySach.XoaSach(masach);
            return RedirectToAction("XemChiTiet", "Home", new { matheloai = xoa.MaTheLoai });


        }



        [HttpGet]
        [Route("/Home/ThayDoiThongTin/{masach}")]
        public IActionResult ThayDoiThongTin(int masach)
        {
            var hocvien = quanlySach.LayVe1Sach(masach);
            return View(hocvien);
        }
        [HttpPost]
        public IActionResult ThayDoiThongTin(Book sach)
        {
            if (ModelState.IsValid)
            {
                var result = quanlySach.ThayDoiThongTin(sach);
                if (result != null)
                {
                    return RedirectToAction("XemChiTiet", "Home", new { matheloai = result.MaTheLoai });
                }
            }
          
            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }

        [Route("/Home/XemChiTietMotSach/{masach}")]
        public IActionResult XemChiTietMotSach(int masach)
        {
            var sach = quanlySach.LayVe1Sach(masach);
            return View(sach);
        }


    }
}
