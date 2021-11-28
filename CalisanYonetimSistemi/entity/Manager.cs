using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.entity {
    class Manager:Employee {
        public Department DepartmentManages { get; set; }
        public Manager Manager_;

        

        public Rank Rank { get; set; }

        public int SpanOfControl { get; set; }
        public Manager(Address adress, Department department, string fullName, string phoneNumber,
            float salaryPerHour, Department departmentManages, Manager manager_, Rank rank, int spanOfControl) : base(adress, department, fullName, phoneNumber, salaryPerHour)
        {
            DepartmentManages = departmentManages;
            Manager_ = manager_;
            Rank = rank;
            SpanOfControl = spanOfControl;
        }

     
    }
}
