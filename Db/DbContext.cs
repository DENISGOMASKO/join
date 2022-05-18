using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join.Db
{
    class DbContext { 
        public IEnumerable<Employee> Staff { get; }
        public IEnumerable<Department> Departments { get; }
    
        public DbContext()
        {
            Departments = new Department[]
            {
                new Department(0, "Бар "),
                new Department(1, "Администрация"),
                new Department(2, "Ай-Ти"),
            };

            Staff = new Employee[]
            {
                new Employee(0, "Паша", 0),
                new Employee(1, "Саша", 1),
                new Employee(2, "Маша", 0),
                new Employee(3, "Глаша", 0),
                new Employee(3, "Даша")
            };

        }
    }
}
