using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class Return
    {
         public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int qty { get; set; }
        public string receiver { get; set; }

        [ForeignKey("product")]
        public int productId { get; set; }

        [ForeignKey("shoppingmall")]
        public int shoppingmallId { get; set; }
        
        public Product product { get; set; }

        public ShoppingMall shoppingmall { get; set; }
    }
}