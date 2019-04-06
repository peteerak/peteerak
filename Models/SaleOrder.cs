using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class SaleOrder
    {
        [Key]
        public int saleID { get; set; }
        public string zone { get; set; }
        public string saleAmount { get; set; }
     
    }
}