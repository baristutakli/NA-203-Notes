using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkulCodeFirstEntitiyFRamework.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        [Index]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}