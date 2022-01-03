using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}