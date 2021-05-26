using assetManagement.Context;
using assetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Repositories.Data
{
    public class ConditionRepository : GeneralRepository<Condition, MyContext, int>
    {
        private readonly MyContext myContext;
        public ConditionRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
