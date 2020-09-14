using Quanlykhachahng.Models;
using Quanlykhachahng.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Services.Impl
{
    public class CustomerServiceImpl : GeneralServiceImpl<Customer, ICustomerRepository>, ICustomerService

    {

        private ICustomerRepository repository;

        public CustomerServiceImpl(ICustomerRepository repository) : base(repository)

        {

            this.repository = repository;

        }



        public async Task<List<Customer>> GetCustomersIncludeProvince()

        {

            return await repository.GetCustomersIncludeProvince();

        }

    }

}
