using Microsoft.EntityFrameworkCore;
using Quanlykhachahng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlykhachahng.Repositories.Impl
{
    public class CustomerRepositoryImpl : GeneralRepositoryImpl<Customer, DataContext>, ICustomerRepository

    {

        private readonly DataContext context;

        public CustomerRepositoryImpl(DataContext context) : base(context)

        {

            this.context = context;

        }



        public async Task<List<Customer>> GetCustomersIncludeProvince()

        {

            return await context.Customers

            .Include(c => c.Province)

            .AsNoTracking().ToListAsync();

        }

    }
}
