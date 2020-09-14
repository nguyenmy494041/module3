using Quanlykhachahng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Services
{
    public interface ICustomerService : IGeneralService<Customer>

    {

        Task<List<Customer>> GetCustomersIncludeProvince();


    }

}
