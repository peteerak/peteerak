using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class CarPlate
    {
        [Key]
        public int carPlateId { get; set; }
        [Required]
        public string carPlateNumber { get; set; } 

       
    }
}