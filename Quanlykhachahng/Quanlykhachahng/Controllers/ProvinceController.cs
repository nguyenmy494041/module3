using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quanlykhachahng.Models;
using Quanlykhachahng.Services;

namespace Quanlykhachahng.Controllers
{
    public class ProvinceController : GeneralController<Province, IProvinceService>

    {
        public ProvinceController(IProvinceService service) : base(service)

        {


        }

    }
}
