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
                new Employee (){Id = 1,Fullname = "Chicharito",Email ="hatdaunho@gmail.com",Department=Dept.FW,AvatarPath="~/images/chicharito.jfif"},
                new Employee (){Id = 2,Fullname = "PaulScholes",Email ="hoangtutocvang@gmail.com",Department=Dept.MF,AvatarPath="~/images/no_image.jfif"},
                new Employee (){Id = 3,Fullname = "Park Ji Sung",Email ="hatdaunho@gmail.com",Department=Dept.MF,AvatarPath="~/images/park.jfif"},
                new Employee (){Id = 4,Fullname = "Rafael Da Silva",Email ="hoangtutocvang@gmail.com",Department=Dept.DF,AvatarPath="~/images/dasilva.jfif"},
                new Employee (){Id = 5,Fullname = "Ferdinand",Email ="hatdaunho@gmail.com",Department=Dept.DF,AvatarPath="~/images/rio.jfif"},
                new Employee (){Id = 6,Fullname = "Carrick",Email ="hoangtutocvang@gmail.com",Department=Dept.MF,AvatarPath="~/images/carrick.jfif"}
            };
        }

        public Employee Create(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.AvatarPath ="~/images/no_image.jfif";
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int id)
        {
            Employee employee = Get(id);
            if (employee!= null)
            {
                employees.Remove(employee);
                return true;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            Employee employee1 = Get(employee.Id);
            employee1.Fullname = employee.Fullname;
            employee1.Email = employee.Email;
            employee1.Department = employee.Department;          
            return employee1;
        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
