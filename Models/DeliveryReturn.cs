using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class DeliveryReturn
    {
        [Key]
        public int id { get; set; }

       
        public DateTime date { get; set; }
        public int qty { get; set; }
        public string status { get; set; }

     
        public DateTime lotdate {get; set; }

        //np
        public int productID { get; set; }
        public Product product { get; set; }
        //end np
       
         //np
        public int shoppingmallID { get; set; }
        public ShoppingMall shoppingmall { get; set; }
        //end np
    }
}