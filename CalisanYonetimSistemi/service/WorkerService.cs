using CalisanYonetimSistemi.entity;
using CalisanYonetimSistemi.service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service {
    class WorkerService : IEmployeeService<Employee> {
        public WorkerService(Employee Employee)
        {
            Employee = Employee;
        }

        public Employee Employee { get; set; }
        
        

        public void AssignMissionToWorker()
        {
            //
        }


        public void Create()
        {
            Console.WriteLine( "Employee added" );

            OnMemoryDataBase.Employees.Add(Employee);
            
        }

      

        public void Delete()
        {
            if ( OnMemoryDataBase.Employees.Contains(Employee))
            {
                Console.WriteLine("Employee deleted");
                OnMemoryDataBase.Employees.Remove(Employee);
            }
        }

     

        public int Find()
        {
            if (OnMemoryDataBase.Employees.Contains(Employee))
            {
                Console.WriteLine("Not Found!");
                return OnMemoryDataBase.Employees.IndexOf(Employee);
            }
            else
            {
                throw new Exception( "Bulunamadı");
            }
        }

    }
}
