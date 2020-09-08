using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTapLon.Models.Contexts;
using BaiTapLon.Models.ProductManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaiTapLon.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext context;

        public ProductController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult ShowSteamFan()
        {

            List<Product> products = context.Products.Include(e => e.Specification)
              .Include(e => e.Images).Include(e => e.Category).ToList();
          
            return View(products);

        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost ]
        public IActionResult CreateProduct(CreateProduct model, IFormFile[] ImageFiles)
        {           
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    ProductId =model.ProductId,
                    ProductName = model.ProductName,
                    ProductPrice =model.ProductPrice,
                    Size =model.Size,
                    Weight =model.Weight,
                    TankCapacity=model.TankCapacity,
                    Brand =model.Brand,
                    Wattage= model.Wattage,
                    Utilities = model.Utilities,
                    CategoryId = model.CategoryId,
                    Manufactures = model.Manufactures,
                    MadeIn= model.MadeIn,
                    Year = model.Year,
                    Description = model.Description 
                };
                context.Products.Add(product);
                var spec = new Specification()
                {
                    Dynamic=model.Dynamic,
                    WindMode =model.WindMode,
                    WindSpeed =model.WindSpeed,
                    Control=model.Control,
                    CollingRange=model.CollingRange,
                    WindFlow=model.WindFlow,
                    FanCageType=model.FanCageType,
                    Noiselevel=model.Noiselevel,
                    WaterConsumption=model.WaterConsumption,
                    MachineModel=model.MachineModel,
                    FilterTechnology=model.FilterTechnology,
                    NumberFilterCores=model.NumberFilterCores,
                    FilterCapacity=model.FilterCapacity,
                    Pumping=model.Pumping,
                    Safemode=model.Safemode,
                    Temperature=model.Temperature,
                    WaterPressure=model.WaterPressure,
                    WarmUpTime=model.WarmUpTime,
                    MaxTemperature=model.MaxTemperature,
                    ProductId=model.ProductId,

                };
                context.Specifications.Add(spec);
                if (model.ImageFiles != null)
                {
                    var iamge = model.ImageFiles.ToList();
                    for (int i = 0; i < iamge.Count; i++)
                    {
                        var anh = new Image()
                        {
                            ProductId = model.ProductId,
                            ImageName = iamge[i].FileName
                        };
                        context.Images.Add(anh);
                    }
                }
                      
               
                context.SaveChanges();
                return RedirectToAction("ShowSteamFan", "Product");
            }
            return View();
        }
    }
}
