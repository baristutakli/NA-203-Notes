using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.service.Api {
    interface IService<T> {
        void Create(T t);
        void Delete(T t);
        int Find(T t);
    }
}
