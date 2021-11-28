using CalisanYonetimSistemi.entity;
using CalisanYonetimSistemi.service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service {
    class ManagerService : IEmployeeService<Employee> {
        public Employee Employee { get; set; }
        public ManagerService(Employee Employee)
        {
            this.Employee = Employee;
        }

        
        public void AssignMissionToWorker()
        {
            //
        }

        public void Create()
        {
            if (Employee is Manager)
            {
                Console.WriteLine("Bu bir yönetici");
            }
            else
            {
                Console.WriteLine("Bu bir çalışan");
            }
        }

        public void Delete()
        {
           //
        }

        public int Find()
        {
            return 0;
        }
    }
}
