using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Item
    {
        
        public string productId {get;set;}
        public string productName { get; set; }
      
        public int productQty {get;set;}

        public double productPrice {get;set;}

        public int shoppingMallId {get; set;}
      
    
       
    }
}