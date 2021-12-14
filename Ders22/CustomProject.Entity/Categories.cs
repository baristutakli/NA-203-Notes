using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomProject.Common;

namespace CustomProject.Entity {

    // Veri tabanındaki tablo karşılığı ve bu tablodaki primary key kolonunu belirttik.

    [Table(PrimaryColumn = "CategoryID", TableName = "Categories",IdendityColumn = "CategoryID")]
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

    }
}
