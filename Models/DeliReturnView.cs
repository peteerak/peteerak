using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class DeliReturnView
    {
        public int id { get; set; }
        public string date { get; set; }
        [Required]
        public int qty { get; set; }
      
        public string status { get; set; }
        [Required]
        public string lotdate {get; set; }

        //np
        [Required]
       
        public string productName { get; set; }
        
        [Required]
        public string shoppingmallName { get; set; }


       
        //end np
    }
}