using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class BakeLot
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int qty { get; set; }

        [ForeignKey("product")]
        public int productId { get; set; }

        public Product product { get; set; }
    }
}