using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Person
    {
        private String name;
        private int age;
        public double salary { get; set; }
        public String country { get; set; }

        public Person()
        {
            salary = 1000;
            country = "VN";
        }

        public delegate double calTax(double salary);

        public double defaultTax(double salary)
        {
            return 7 * salary / 100;
        }

        public double VNTax(double salary)
        {
            return 10 * salary / 100;
        }

        public double USATax(double salary)
        {
            return 5 * salary / 100;
        }

        public double getTax()
        {
            calTax cal = defaultTax;
            if (country == "VN")
            {
                return VNTax(this.salary);
            }
            else if (country == "USA")
            {
                return USATax(this.salary);
            }
            else
            {
                return defaultTax(this.salary);
            }

        }

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + name + " - Age: " + age);
        }
    }
}
