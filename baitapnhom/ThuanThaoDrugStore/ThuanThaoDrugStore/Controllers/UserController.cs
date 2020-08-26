using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ThuanThaoDrugStore.Models;

namespace ThuanThaoDrugStore.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext context;

        public UserController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaiKhoan taikhoan)
        {
            taikhoan.Diachi += ", " + context.PhuongXa.Find(int.Parse(taikhoan.PhuongXa)).TenPhuongXa;
            taikhoan.Diachi += ", " + context.QuanHuyen.Find(int.Parse(taikhoan.QuanHuyen)).TenQuanHuyen;
            taikhoan.Diachi += ", " + context.TinhThanh.Find(int.Parse(taikhoan.TinhTp)).TenTinhThanh;

            context.Account.Add(taikhoan);
            context.SaveChanges();
           
            return RedirectToAction("Show", "User");
        }
        public JsonResult LayraQuanHuyen(int? id = 1)
        {
            var data = context.QuanHuyen.Where(x => x.Id_TinhThanh == id).OrderBy(x => x.TenQuanHuyen).ToList();
            return Json(data);
        }

        public JsonResult LayraTinhThanh()
        {
            var data = context.TinhThanh.OrderBy(x => x.TenTinhThanh).ToList();
            return Json(data);
        }
        public JsonResult LayraPhuongXa(int? id = 1)
        {
            var data = context.PhuongXa.Where(x => x.Id_QuanHuyen == id).OrderBy(x => x.TenPhuongXa).ToList();
            return Json(data);
        }

        public IActionResult Show()
        {
            return View();
        }

    }
}
