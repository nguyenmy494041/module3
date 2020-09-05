using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangQuatNuoc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult CreateSteamFan()
        {
            return View();
        }
    }
}
