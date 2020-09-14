﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quanlykhachahng.Models;
using Quanlykhachahng.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Controllers
{
    public class CustomerController : GeneralController<Customer, ICustomerService>

    {
        //public CustomerController(ICustomerService service) : base(service)

        //{

        //}


        private IProvinceService provinceServiceImpl;

        private ICustomerService service;



        public CustomerController(ICustomerService service, [FromServices] IProvinceService provinceServiceImpl) : base(service)

        {

            this.provinceServiceImpl = provinceServiceImpl;

            this.service = service;

        }



        [HttpGet()]

        public override async Task<IActionResult> Create()

        {

            ViewBag.Provinces = await provinceServiceImpl.GetAll();

            return View();

        }

        [HttpGet("Customer/Index")]

        public async Task<ActionResult<IEnumerable<Customer>>> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)

        {

            ViewData["CurrentSort"] = sortOrder;

            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            ViewData["AddressSortParm"] = String.IsNullOrEmpty(sortOrder) ? "address_desc" : "";



            if (searchString != null)

            {

                pageNumber = 1;

            }

            else

            {

                searchString = currentFilter;

            }



            ViewData["CurrentFilter"] = searchString;



            var entitiesService = await service.GetCustomersIncludeProvince();

            var entities = entitiesService.AsQueryable();




            if (!String.IsNullOrEmpty(searchString))

            {

                entities = entities.Where(s => s.Name.Contains(searchString));

            }



            switch (sortOrder)

            {

                case "name_desc":

                    entities = entities.OrderByDescending(s => s.Name);

                    break;

                case "address_desc":

                    entities = entities.OrderByDescending(s => s.Address);

                    break;

                default:

                    entities = entities.OrderBy(s => s.Name);

                    break;

            }

            int pageSize = 3;

            return View(await PaginatedList<Customer>.CreateAsync(entities.AsNoTracking(), pageNumber ?? 1, pageSize));

        }




        [HttpGet]

        public override async Task<ActionResult<Customer>> Edit(int id)

        {

            ViewBag.Provinces = await provinceServiceImpl.GetAll();

            var t = await service.Get(id);

            if (t == null)

            {

                return NotFound();

            }

            return View(t);

        }

    }

}




