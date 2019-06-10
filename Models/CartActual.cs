using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class CartActual
    {
        [Key]
        public int cartId {get;set;}
        public DateTime createdDate {get;set;}
       
        public DateTime dateSold { get; set; }
        public double totalRevenue { get; set; }


        public int branchId { get; set; }
        public Branch branch { get; set; }
        public int shoppingmallID { get; set; } // 1 => the mall
        public ShoppingMall shoppingmall { get; set; }

        public List<CartItemActual> cartItems {get;set;} //FK to caritem table


        
     
    }
}