using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class CartItemActual
    {
        [Key]
        public int cartItemId {get;set;}

        public string productId {get;set;}
        public string shoppingMallId {get;set;}
      
        public int productQty {get;set;}
        
        //reverse NP
        public int cartId {get;set;} 
     
    }
}