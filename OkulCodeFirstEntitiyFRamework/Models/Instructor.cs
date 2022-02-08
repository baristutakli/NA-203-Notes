using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirstEntitiyFRamework.Models
{
    public class Instructor:User
    {
        public double Salary { get; set; }
        [MaxLength(30)]
        public string Department { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}