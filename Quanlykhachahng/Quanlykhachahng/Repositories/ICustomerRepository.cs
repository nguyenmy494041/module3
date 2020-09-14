using Quanlykhachahng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Repositories
{
    public interface ICustomerRepository : IGeneralRepository<Customer>

    {

        Task<List<Customer>> GetCustomersIncludeProvince();


    }

}
