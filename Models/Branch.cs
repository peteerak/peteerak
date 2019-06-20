using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Branch
    {
        [Key]
        public int branchId { get; set; }
        [Required]
        public string branchName { get; set; } //tha pra

        //np
        public int shoppingmallID { get; set; } // 1 => the mall
        public ShoppingMall shoppingmall { get; set; }
        //end np
       
    }
}