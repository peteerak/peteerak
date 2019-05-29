using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class CartActualView
    {
        public int Id {get;set;}
        public DateTime date {get;set;}  
        public double total  {get;set;}
        public string shoppingMallName { get; set; }


        
     
    }
}