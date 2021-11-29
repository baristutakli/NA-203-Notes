using CalisanYonetimSistemi.entity;
using CalisanYonetimSistemi.service.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service {
    class WorkerService : IEmployeeService<Employee> {

        public void AssignMissionToWorker()
        {
            //
        }
      

        public void Create(Employee t)
        {
            if (t is Worker)
            {
                OnMemoryDataBase.Employees.Add((Worker)(object)t);
                Console.WriteLine("Employee added");
            }
            else
            {
                Console.WriteLine("Oluşturulamadı");

            }
        }

        public void Delete(Employee t)
        {
            if (t is Worker && OnMemoryDataBase.Employees.Contains((Worker)(object)t))
            {
                OnMemoryDataBase.Employees.Remove((Worker)(object)t);
                Console.WriteLine("Employee deleted");
            }
        }

      

        public int Find(Employee t)
        {
            if (t is Worker && OnMemoryDataBase.Employees.Contains((Worker)(object)t))
            {
                Console.WriteLine("You found it!");
                return OnMemoryDataBase.Employees.IndexOf((Worker)(object)t);


            }
            else
            {
                throw new Exception("Bulunamadı");
            }
        }

      
    }
}
