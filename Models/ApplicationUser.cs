using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace kafer_house.Models
{

  public class Roles
  {
      public const string Admin = "Admin";
      public const string Manager = "Manager";
      public const string Staff = "Staff";
      public static string[] getRoles()
      {
          return new string[] { Admin, Manager, Staff };
      }
  }

  //step two
  
  public class ApplicationUser : IdentityUser<int>
  {
         
        [Required]
        [DisplayName("First Name")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string GetFullName => this.FirstName + " " + this.LastName;

        public Staff Staff {get ;set; }
        public Manager Manager {get ;set; }
  }
}