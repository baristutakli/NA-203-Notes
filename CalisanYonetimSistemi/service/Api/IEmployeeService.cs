using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service.Api {
    interface IEmployeeService<T>: IService<T> where T: Employee   {

        void AssignMissionToWorker();
        // 
        // where T:class,IService<T>, new()
    }
}
