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

            var queryInner =
                from emp in staff
                join dep in deps
                    on emp.DepartmentId equals dep.Id
                select new { emp = emp.Name, dep = dep.Name };

            var queryLeft =
                from emp in staff
                join dep in deps
                    on emp.DepartmentId equals dep.Id
                into department
                from depWithNull in department.DefaultIfEmpty()
                select new { emp = emp.Name, dep = depWithNull?.Name ?? "noData" };

            var queryRight =
                from dep in deps
                join emp in staff
                    on dep.Id equals emp.DepartmentId
                into staffs
                from stafsfWithNull in staffs.DefaultIfEmpty()
                select new { emp = stafsfWithNull?.Name ?? "noData", dep = dep.Name  };

            var queryFull =
                queryLeft.Union(queryRight);



            foreach (var i in queryLeft)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (var i in queryRight)
            {
                Console.WriteLine(i);
            }
        }
    }
}
