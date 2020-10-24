using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAccessDatabaseViaADO.model
{
    class Customer
    {
        private int id;
        private String name;
        private String address;
        private String city;
        private String country;
        private String phone;
        private String zipcode;
        private String dob;
        private String gender;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }

        public Customer()
        {

        }

        public Customer(string name, string address, string city, string country, string phone, string zipcode)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.zipcode = zipcode;
        }

        public Customer(int id, string name, string address,
            string city, string country, string phone, string zipcode, String dob, string gender)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.zipcode = zipcode;
            this.Dob = dob;
            this.gender = gender;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
