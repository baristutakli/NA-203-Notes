using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Deneme {
    class Person {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void WhoAmI()
        {
            Console.WriteLine($"I am a person and my name is {this.FirstName}");
        }

    }
}
