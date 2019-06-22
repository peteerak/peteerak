using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class ProductLoss
    {

      public string productName { get; set; }
      public double productSent { get; set; }
      public double productReceived { get; set; }
      public double productActual { get; set; }
      public double productLoss { get; set; }
    }
}