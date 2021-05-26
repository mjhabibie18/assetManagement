using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class CategoryRepository : GeneralRepository<Category, MyContext, int>
    {
        private readonly MyContext myContext;
        public CategoryRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
