using Quanlykhachahng.Models;
using Quanlykhachahng.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Services.Impl
{
    public class ProvinceServiceImpl : GeneralServiceImpl<Province, IProvinceRepository>, IProvinceService

    {
        public ProvinceServiceImpl(IProvinceRepository repository) : base(repository)

        {


        }

    }
}
