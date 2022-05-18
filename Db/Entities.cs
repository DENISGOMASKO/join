using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join.Db
{

    abstract record Entity(int Id, string Name);
    record Employee : Entity
    {
        public int? DepartmentId { get; init; }

        public Employee(int Id, string Name, int? DepartmentId = null) : base(Id, Name) => this.DepartmentId = DepartmentId;

    }
    record Department : Entity
    {
        public Department(int Id, string Name) : base(Id, Name){

        }
    }

    //TODO record Banks
}
