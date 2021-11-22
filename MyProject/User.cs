using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject {
    class User {
        static int countUsers = 0;
        string firstName;
        string lastName;
        string tel;
        List<Product> products;

        public User(string firstName, string lastName, string tel)
        {
            products = new List<Product>();
            this.firstName = firstName;
            this.lastName = lastName;
            this.tel = tel;
            countUsers += 1;
        }

        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string Tel { get => tel; }

        public override string ToString()
        {
            string info = "Products: ";
            if (products.Count >= 1)
            {
                foreach (Product item in products)
                {

                    info += item.ToString();
                }
                return $"First name: {FirstName}\t Last name: {LastName}\t Tel:{Tel}\n {info}";
            }
            return $"First name: {FirstName}\t Last name: {LastName}\t Tel:{Tel}\n {info}-";


        }
        public void ChangeUserInfo(string newFirstName)

        {
            if (!String.IsNullOrEmpty(newFirstName) && (!String.IsNullOrWhiteSpace(newFirstName)))
            {
                this.firstName = newFirstName;
            }
            
        }

        public void ChangeUserInfo(string newFirstName, string newLastName)
        {
            this.firstName = newFirstName;
        }
        public void ChangeUserInfo(string newFirstName, string newLastName, string newTel)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.tel = newTel;

        }

        public void SellProduct(string title, string details, string options, int price)
        {
            Product newProduct = new Product(title, details, options, price);

            if (!products.Contains(newProduct))
            {
                this.products.Add(newProduct);
            }



        }

        public void ModifyProduct(string title, string details, string options, int price)
        {
            foreach (Product product in products)
            {
                if (product.Title.Equals(title))
                {
                    product.Details = details;
                    product.Options = options;
                    product.Price = price;

                }
            }

        }
    }
}
