using CalisanYonetimSistemi.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi {
    abstract class Employee {
        static int IdCounter=0;
        Address adress;
        Department department;
        string fullName;
        int id;
        string phoneNumber;
        float salaryPerHour;
        float totalSalary;
        short workingHours;

        protected Employee(Address adress, Department department, string fullName, string phoneNumber, float salaryPerHour)
        {
            IdCounter += 1;
            this.adress = adress;
            this.department = department;
            this.fullName = fullName;
            this.id = IdCounter;
            this.phoneNumber = phoneNumber;
            this.salaryPerHour = salaryPerHour;
        }

        public Address Adress { get => adress; set => adress = value; }
        public Department Department { get => department; set => department = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Id { get => id; set => id = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public float SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
        public float TotalSalary { get => totalSalary; set => totalSalary = value; }
        public short WorkingHours { get => workingHours; set => workingHours = value; }
    }
}
