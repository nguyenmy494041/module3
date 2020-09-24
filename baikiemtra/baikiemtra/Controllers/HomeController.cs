using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using baikiemtra.Models;
using baikiemtra.Serviceesss;
using baikiemtra.Models.Entities;
using System.Security.Policy;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace baikiemtra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILophocServices lophocServices;
        private readonly AppDbContext context;

        public HomeController(ILogger<HomeController> logger, ILophocServices lophocServices,AppDbContext context)
        {
            _logger = logger;
            this.lophocServices = lophocServices;
            this.context = context;
        }
        public IActionResult DanhSachCacLop()
        {
            var caclop = lophocServices.LayDanhSachCacLop();
            return View(caclop);
        }
        [Route("/Home/DanhSachHocSinh/{malop}")]
        public IActionResult DanhSachHocSinh(int malop)
        {
            ViewBag.malop = new HocVien() { MaLop = malop };
            var hocviens = lophocServices.LayDanhSachHocVienTheoLop(malop);
            return View(hocviens);
        }
        [HttpGet]
        [Route("/Home/ThemMoiHocVien/{malop}")]
        public IActionResult ThemMoiHocVien(int malop)
        {
            ViewBag.malop = new HocVien() { MaLop = malop };
            return View();
        }
        [HttpPost]
        public IActionResult ThemMoiHocVien(HocVien hocVien)
        {
            var result = lophocServices.ThemMoiHocVien(hocVien);
            if (result > 0)
            {
                return RedirectToAction("DanhSachHocSinh", "Home", new { malop = hocVien.MaLop });
            }
            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }

        [HttpGet]
        [Route("/Home/ThayDoiThongTin/{mahocvien}")]
        public IActionResult ThayDoiThongTin(int mahocvien)
        {
            var hocvien = lophocServices.LayVe1HocVien(mahocvien);
            return View(hocvien);
        }
        [HttpPost]
        public IActionResult ThayDoiThongTin(HocVien hocVien)
        {
            var result = lophocServices.ThayDoiThongTin(hocVien);
            if (result != null)
            {
                return RedirectToAction("DanhSachHocSinh", "Home", new { malop = result.MaLop });
            }
            ViewData["Message"] = "Học viên đã tồn tại";
            return View();
        }
        [Route("/Home/XoaHocSinh/{mahocvien}")]
        public IActionResult XoaHocSinh(int mahocvien)
        {
            var xoa = lophocServices.XoaHocSinh(mahocvien);            
                return RedirectToAction("DanhSachHocSinh", "Home", new { malop = xoa.MaLop });
            

        }

    }
}
