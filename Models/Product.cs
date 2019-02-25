using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public int price { get; set; }
    }
}