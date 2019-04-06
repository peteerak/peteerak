using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class DeliReturnView
    {
        public int id { get; set; }
        public string date { get; set; }
        public int qty { get; set; }
        public string status { get; set; }
        public string lotdate {get; set; }

        //np
        public string productName { get; set; }
        public string shoppingmallName { get; set; }


       
        //end np
    }
}