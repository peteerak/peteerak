using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class DeliveryReturn
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        [Required]
        public int qty { get; set; }
        public string status { get; set; }

     
        public DateTime lotdate {get; set; }

        //np
        [Required]
        public int productID { get; set; }
        
        public Product product { get; set; }
        //end np

        //np
        [Required]
        public int shoppingmallID { get; set; }
        public ShoppingMall shoppingmall { get; set; }
        //end np
    }
}