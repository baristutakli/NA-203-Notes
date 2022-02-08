using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OkulCodeFirstEntitiyFRamework.Models
{
    public class Student:User
    {
        [Required]
        public short SchoolNo { get; set; }
        public string Class { get; set; }
        [Required]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}