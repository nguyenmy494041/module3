using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToKhaiYte.Models;
using ToKhaiYte.Models.ViewModel;
using ToKhaiYte.Services;

namespace ToKhaiYte.Controllers
{
    public class HomeController : Controller
    {
        private const int defaultProvinceId = 15;
        private const int defaultDistrictId = 194;
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext context;
        private readonly IToKhaiServices services;

        public HomeController(ILogger<HomeController> logger,
                                AppDbContext context,
                                IToKhaiServices services)
        {
            _logger = logger;
            this.context = context;
            this.services = services;
        }

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
        public IActionResult Dangky()
        {
            
            return View(CollectData());
        }

        [HttpPost]
        public IActionResult Dangky(DangKyToKhai tokhai)
        {
            if (ModelState.IsValid)
            {
                var result = services.TaoMoiToKhai(tokhai);
                if (result > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "System error, please try again later!");
            }
            var DangkyView = new DangKyToKhai();
            return View(DangkyView);
        }

        private DangKyToKhai CollectData()
        {
            var model = new DangKyToKhai();
            model.cuakhaus = services.LayDanhSachCuaKhau();
            model.quocgias = services.LayDanhSachQuocGia();
            model.tinhthanhs = services.LayDanhsachTinhThanhVietNam();
           
            return model;
        }

        [Route("/Home/TinhThanh/{TinhThanhId}")]
        public IActionResult LayDanhSachQuanHuyen(int TinhThanhId)
        {
            var quanhuyens = services.LayDanhSachQuanHuyen(TinhThanhId);
            return Json(new { quanhuyens });
        }
         
        [Route("/Home/TinhThanh/QuanHuyen/{QuanHuyenId}")]
        public IActionResult LayDanhSachPhuongXa (int QuanHuyenId, int TinhThanhId)
        {
            var phuongxas = services.LayDanhSachPhuongXa(QuanHuyenId, TinhThanhId);
            return Json(new { phuongxas });
        }

        public IActionResult Danhsach()
        {
            //var result = 
            return View();

        }
    }
}
