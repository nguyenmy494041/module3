using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CuaHangQuatNuoc.Models.AppDbContext;
using CuaHangQuatNuoc.Models.Products;

using Microsoft.AspNetCore.Mvc;

namespace CuaHangQuatNuoc.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext context;


        public ProductController(AppDbContext context)
        {
            this.context = context;

        }


        [HttpGet]
        public IActionResult CreateSteamFan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSteamFan(SteamFan fan)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    ProductId = fan.ProductId,
                    ProductName = fan.ProductName,
                    ProductPrice = fan.ProductPrice,
                    CategoryId = 1,
                    Size = fan.Size,
                    Wattage = fan.Wattage,
                    MadeIn = fan.MadeIn,
                    Manufactures = fan.Manufactures,
                    Description = fan.Description,
                    TankCapacity = fan.TankCapacity,
                    Utilities = fan.Utilities,
                    Brand = fan.Brand,
                    Year = fan.Year,
                    Weight = fan.Weight
                };
                context.Products.Add(product);

                var spectification = new Specification()
                {
                    //ProductId = fan.ProductId,
                    Dynamic = fan.Dynamic,
                    WindFlow = fan.WindFlow,
                    WindMode = fan.WindMode,
                    WindSpeed = fan.WindSpeed,
                    CollingRange = fan.CollingRange,
                    Control = fan.Control,
                    FanCageType = fan.FanCageType,
                    Noiselevel = fan.Noiselevel,
                    WaterConsumption = fan.WaterConsumption
                };
                context.Specifications.Add(spectification);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

    }
}
