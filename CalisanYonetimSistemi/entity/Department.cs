using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.entity {
    class Department {
        static byte s_IdDepartment=0;
        public int IdDepartment = 0;
        
        public List<Employee> Employees;

        public Manager HeadOf { get; set; }

        public string Name { get; set; }

        public Department( string name)
        {
            s_IdDepartment += 1;
            IdDepartment = s_IdDepartment;
            Employees = new List<Employee>();
            Name = name;
        }
    }
}
