using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service.Api {
    interface IService<T> {
        void Create ();
        void Delete();
        int Find();
    }
}
