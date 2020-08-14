using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee (){Id = 1,Fullname = "Chicharito",Email ="hatdaunho@gmail.com",Department="It",AvatarPath="~/images/soaica.jfif"},
                new Employee (){Id = 2,Fullname = "PaulScholes",Email ="hoangtutocvang@gmail.com",Department="It",AvatarPath="~/images/no_image.jfif"}
            };
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
