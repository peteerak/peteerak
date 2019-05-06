using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string name { get; set; }
        public string code { get; set; }
        public double price { get; set; }


        
        //shoppingMall has many deliveryReturn table
        public ICollection<DeliveryReturn> deliveryreturn { get; set; }
     
    }
}