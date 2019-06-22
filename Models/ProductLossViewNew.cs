using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class ProductLossViewNew
    {

      public string ShoppingMall { get; set; }
      public string Branch { get; set; }
      public IEnumerable<ProductLoss> AllItems {get;set;}

      public IEnumerable<ProductLoss> deliveryItems {get;set;}
      public IEnumerable<ProductLoss> receiveItems {get;set;}
      public IEnumerable<ProductLoss> actualItems {get;set;}


    }
}