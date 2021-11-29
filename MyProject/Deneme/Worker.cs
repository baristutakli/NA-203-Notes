using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Deneme {
    class Worker:Person {
        public string Mission { get; set; }
        public Worker(string firstName, string lastName, string email, string mission ) : base(firstName, lastName, email)
        {
            Mission = mission;
        }
        public void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine($"{this.FirstName} is also a worker");
        }

    }
}
