﻿using assetManagement.Base;
using assetManagement.Models;
using assetManagement.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionItemController : BaseController<ConditionItem, ConditionItemRepository, int>
    {
        private ConditionItemRepository conditionitemRepository;
        public ConditionItemController(ConditionItemRepository conditionitemRepository) : base(conditionitemRepository)
        {
            this.conditionitemRepository = conditionitemRepository;
        }
    }
}
