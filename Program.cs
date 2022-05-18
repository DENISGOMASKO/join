using System;
using System.Linq;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Db.DbContext data = new();
            var staff = data.Staff;
            var deps = data.Departments;

            var query =
                from emp in staff
                from dep in deps
                where emp.DepartmentId == dep.Id
                select new { emp = emp.Name, dep = dep.Name };
            foreach(var i in query)
            {
                Console.WriteLine(i);
            }
        }
    }
}
