using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomProject.Common;

namespace CustomProject.Entity
{
    [Table(PrimaryColumn = "ShipperID", TableName = "Shippers",IdendityColumn = "ShipperID")]
    public class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
