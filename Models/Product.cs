using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
       [StringLength(60, MinimumLength = 2)] 
        [Required]
        public string name { get; set; }
        [StringLength(6, ErrorMessage = "Code length must be 6.", MinimumLength = 6)]
        [Required]
        public string code { get; set; }
        [Range(0, 999.99)]
        public double price { get; set; }


        
        //shoppingMall has many deliveryReturn table
        public ICollection<DeliveryReturn> deliveryreturn { get; set; }
     
    }
}