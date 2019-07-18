using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        
        [DisplayName("First Name")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [MaxLength(25)]
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string GetFullName => this.FirstName + " " + this.LastName;
        
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}