﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Models
{
    [Table("TB_M_Transaction")]
    public class TransactionItem
    {
        [Key]
        public int Id { get; set; }

    }
}
