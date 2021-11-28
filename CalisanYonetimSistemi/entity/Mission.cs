using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.entity {
    class Mission {
        static int s_idCounter = 0;
        private int id;

        public int Id { get => id; set => id = value; }
        public int missiınId { get; set; }

        public DateTime DeadLine{get;set;}

        public string Description { get; set; }
        

        public List<Employee> EmployeesWorkOn;

        public Mission( int missiınId, DateTime deadLine, string description, List<Employee> employeesWorkOn)
        {
            s_idCounter += 1;
            Id = s_idCounter;
            this.missiınId = missiınId;
            DeadLine = deadLine;
            Description = description;
            EmployeesWorkOn = new List<Employee>();
        }

        public void AssignWorker(Employee worker)
        {
            EmployeesWorkOn.Add(worker);
        }
    }
}
