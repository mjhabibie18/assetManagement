using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employee, MyContext, int>
    {
        private readonly MyContext myContext;
        public EmployeeRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
