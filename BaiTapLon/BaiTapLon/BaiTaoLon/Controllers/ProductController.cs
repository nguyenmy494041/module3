using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BaiTapLon.Models.Contexts;
using BaiTapLon.Models.ProductManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.EntityFrameworkCore;

namespace BaiTapLon.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
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
                    BrandId =model.BrandId,
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
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");

                    for (int i = 0; i < iamge.Count; i++)
                    {
                        string fileName = $"{Guid.NewGuid()}_{iamge[i].FileName}";
                        var filePath = Path.Combine(uploadFolder, fileName);
                        using (var fs = new FileStream(filePath, FileMode.Create))
                        {
                            iamge[i].CopyTo(fs);
                        }
                        var anh = new Image()
                        {
                            ProductId = model.ProductId,
                            ImageName = fileName
                        };
                        context.Images.Add(anh);
                    }
                }
                      
               
                context.SaveChanges();
                return RedirectToAction("ShowSteamFan", "Product");
            }
            return View();
        }

        public IActionResult Detail(string id)
        {
            List<Product> data = context.Products.Include(e => e.Specification)
             .Include(e => e.Images).Include(e => e.Category).Include(e => e.Brand).ToList();

            var result = data.Where(e => e.ProductId == id);
            var df = result.FirstOrDefault();
            if (result != null)
            {
                return View(df);
            }
            //foreach (var pro in data)
            //{
            //    if (pro.ProductId == id)
            //    {
            //        return View();
            //    }
            //}
            //if (pro!=null)
            //{
            //    return View();
            //}
            return View("~/Views/Shared/Error.cshtml",id);
        }
    }
}
