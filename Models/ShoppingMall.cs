using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class ShoppingMall
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
     
    }
}