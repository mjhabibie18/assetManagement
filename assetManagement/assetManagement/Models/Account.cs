﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
    }
}
