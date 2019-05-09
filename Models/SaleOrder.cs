// using System;
// using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class SaleOrder
    {
        [Key]
        public int saleID { get; set; }
        [Required]
        public int zone { get; set; }
        [Range(0, 999)]

        public double saleAmount { get; set; }
     
    }
}