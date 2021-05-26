using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Models
{
    public class ConditionItem
    {
        [Key]
        public int Id { get; set; }
        public Item Item { get; set; }
        public Condition Condition { get; set; }

    }
}
