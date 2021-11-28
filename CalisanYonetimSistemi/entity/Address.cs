using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanYonetimSistemi.entity {
    class Address {
        public Address(string city, string country, string houseNumber, string street, string zipCode)
        {
            City = city;
            Country = country;
            HouseNumber = houseNumber;
            Street = street;
            ZipCode = zipCode;
        }

        public string City { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }

        public string Street { get; set; }
        public string ZipCode { get; set; }

    }
}
