using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Receive
    {
        [Key]
        public int receiveId { get; set; }

        public DateTime receiveDate { get; set; }
        public DateTime productLotDate {get; set; }

        public int branchId { get; set; }
        public Branch branch { get; set; }
        
        public int shoppingmallID { get; set; } // 1 => the mall
        public ShoppingMall shoppingmall { get; set; }
        public List<ReceiveItem> receiveItem {get;set;}

    }
}