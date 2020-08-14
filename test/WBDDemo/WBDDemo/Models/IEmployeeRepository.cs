using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
    }
}
