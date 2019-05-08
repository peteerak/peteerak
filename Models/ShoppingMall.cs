using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class ShoppingMall
    {
        [Key]
        public int id { get; set; } // 1
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string name { get; set; } // the mall

        //shoppingMall has many branch
        public ICollection<Branch> branchs { get; set; }
     
    }
}