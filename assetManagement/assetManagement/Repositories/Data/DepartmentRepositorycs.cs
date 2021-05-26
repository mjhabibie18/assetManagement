using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class DepartmentRepository : GeneralRepository<Department, MyContext, int>
    {
        private readonly MyContext myContext;
        public DepartmentRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
