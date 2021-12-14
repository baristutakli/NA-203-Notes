using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Common
{
    public interface IORM<T> where T: class,new() // Tip class olmalı.
    {
        List<T> Select(); // abstract metot

        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        /*
         *   Categories c = New Categories()
         *   Insert(c)
         */

    }
}
