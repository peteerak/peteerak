using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class ShoppingMall
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Branch> branchs { get; set; }
     
    }
}