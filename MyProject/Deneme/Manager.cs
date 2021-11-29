using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Deneme {
    class Manager: Person {
        public List<string> Teams { get; set; }
        public Manager(string firstName, string lastName, string email, List<string> teams) : base(firstName, lastName, email)
        {
            Teams = teams;
        }
        public void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine($"{this.FirstName} is also a manager");
        }

    }
}
