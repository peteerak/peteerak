using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class ActualSold
    {
        [Key]
        public int id { get; set; }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int qty { get; set; }

        
        public double price { get; set; }


        
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