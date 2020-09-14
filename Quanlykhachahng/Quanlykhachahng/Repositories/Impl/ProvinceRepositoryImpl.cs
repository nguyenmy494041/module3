using Quanlykhachahng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Repositories.Impl
{
    public class ProvinceRepositoryImpl : GeneralRepositoryImpl<Province, DataContext>, IProvinceRepository

    {

        public ProvinceRepositoryImpl(DataContext context) : base(context)

        {



        }

    }
}
