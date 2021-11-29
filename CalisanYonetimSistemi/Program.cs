using CalisanYonetimSistemi.entity;
using CalisanYonetimSistemi.service;
using CalisanYonetimSistemi.service.Api;
using System;

namespace CalisanYonetimSistemi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            Employee employee = new Worker(new Address("İstanbul","Turkiye","42","Aslan","34444"),new Department("IT"),"Barış Akarsu","5555555",1000);
            WorkerService workerService = new WorkerService(
                employee
                );
            
            workerService.Create();
            workerService.Delete();
            workerService.Create();
            workerService.Find();
          
            Employee employee2= new Worker(new Address("İstanbul", "Turkiye", "42", "Aslan", "34444"), new Department("IT"), "Barış Akarsu", "5555555", 1000);
            ManagerService managerService = new ManagerService(employee2);
            managerService.Create();*/

            /*
            Department de = new Department("IT");
            WorkerService workerService3 = new WorkerService(
                de/// burada bize diyor ki sen bana departman veremezsin, onu çeviremiyorum. Bu şekilde filtreleme 
                // yapmışısz
                );*/

            /*
            WorkerService workerService3 = new WorkerService(

                // IService<Worker> girdiğim zaman valid olmadığını söylüyor
                );*/


            // Constructor kullanmadan metoda parametre vermek istiyorum. 
            // Her eleman için  bir worker service oluşturulmaz. Bundna dolayı parametre olarak vermek istiyorum
            Employee employee = new Worker(new Address("İstanbul", "Turkiye", "42", "Aslan", "34444"), new Department("IT"), "Barış Akarsu", "5555555", 1000);
            WorkerService workerService = new WorkerService();
            Department de = new Department("IT");
            workerService.Create(employee);
            workerService.Delete(employee);
        }
    }
}
