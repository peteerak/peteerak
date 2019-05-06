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
        
        public List<CartItemActual> cartItems {get;set;} //FK to caritem table


        
     
    }
}