using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Branch
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int shoppingmallID { get; set; }
        public ShoppingMall shoppingmall { get; set; }
       
    }
}