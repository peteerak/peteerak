using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        [ForeignKey("role")]
        public int roleId { get; set; }

        public Role role { get; set; }
    }
}