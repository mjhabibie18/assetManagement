using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class ItemRepository : GeneralRepository<Item, MyContext, int>
    {
        private readonly MyContext myContext;
        public ItemRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
