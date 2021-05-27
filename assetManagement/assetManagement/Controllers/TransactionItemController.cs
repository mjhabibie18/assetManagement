using assetManagement.Base;
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
    public class TransactionItemController : BaseController<TransactionItem, TransactionItemRepository, int>
    {
        private TransactionItemRepository transactionitemRepository;
        public TransactionItemController(TransactionItemRepository transactionitemRepository) : base(transactionitemRepository)
        {
            this.transactionitemRepository = transactionitemRepository;
        }
    }
}
