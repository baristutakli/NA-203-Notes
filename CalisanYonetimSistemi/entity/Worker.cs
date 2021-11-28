using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.entity {
    class Worker : Employee {
        public List<Mission> Missions;



        public Worker(Address adress, Department department, string fullName, string phoneNumber, float salaryPerHour) : base(adress, department, fullName, phoneNumber, salaryPerHour)
        {
            Missions = new List<Mission>();
        }

        public void Assign(Mission newMission)
        {
            Missions.Add(newMission);
        }

    }


}
