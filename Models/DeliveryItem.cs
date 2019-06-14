using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class DeliveryItem
    {
        [Key]
        public int deliveryItemId {get;set;}

        public string productId {get;set;}
        public string productName {get; set;}
      
        public int productQty {get;set;}
 
        public double productPrice {get;set;}
        
        //reverse NP
        public int deliveryId {get;set;} 
     
    }
}