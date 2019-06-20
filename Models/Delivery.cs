using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Delivery
    {
        [Key]
        public int deliveryId { get; set; }

        public DateTime deliveryDate { get; set; }
        public DateTime productLotDate {get; set; }
 
        public int branchId { get; set; } 
        public Branch branch { get; set; }
        
        public int shoppingmallID { get; set; } // 1 => the mall
        public ShoppingMall shoppingmall { get; set; }
        public List<DeliveryItem> deliveryItem {get;set;}

    }
}