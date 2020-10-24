using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Employee
    {
        private int id { get; set; }
        private string name { get; set; }
        private string designation { get; set; }
        private DateTime dob { get; set; }
        private char gender { get; set; }
        private byte tenure { get; set; }
        private double bonus { get; set; }
        private double salary { get; set; }
        private double taxAmount { get; set; }
        private double netSalary { get; set; }
        private int age { get; set; }

        public Employee()
        {
            name = "";
            designation = "";
            bonus = 0;
            salary = 0;
            taxAmount = 0;
            netSalary = 0;
        }

        public Employee(int id, string name, string designation,
            DateTime dob, char gender, byte tenure,
            double bonus, double salary, double taxAmount, double netSalary, int age)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.dob = dob;
            this.gender = gender;
            this.tenure = tenure;
            this.bonus = bonus;
            this.salary = salary;
            this.taxAmount = taxAmount;
            this.netSalary = netSalary;
            this.age = age;
        }

        public DateTime inputDob()
        {
            Console.Write("Enter dob: ");
            String line = Console.ReadLine();
            DateTime dob;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob)
                 || (DateTime.Now.Year - this.dob.Year <= 18))
            {
                if (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                {
                    Console.Write("Wrong format, re-enter: ");
                    line = Console.ReadLine();
                }
                else
                {
                    Console.Write("Age must be more than 18, re-enter: ");
                    line = Console.ReadLine();
                }

            }
            return dob;
        }

        public int inputID()
        {
            Console.Write("Enter ID:");
            String line = Console.ReadLine();
            int id;
            while (!int.TryParse(line, out id))
            {
                Console.Write("Wrong format, re-enter: ");
                line = Console.ReadLine();
            }
            return id;
        }

        public String inputName()
        {
            Console.Write("Enter name:");
            String name = Console.ReadLine();
            while (name.Length <= 0 || name.Length > 40)
            {
                Console.Write("Wrong format, re-enter: ");
                name = Console.ReadLine();
            }
            return name;
        }

        public char inpurGender()
        {
            Console.Write("Enter gender (M/F):");
            String line = Console.ReadLine();
            char gender;
            while (!char.TryParse(line, out gender) || (gender != 'M' && gender != 'F'))
            {
                Console.Write("Wrong format, re-enter: ");
                line = Console.ReadLine();
            }
            return gender;
        }

        public string inputDesignation()
        {
            Console.WriteLine("Select designation (choose the number): ");
            Console.WriteLine("1. Manager ");
            Console.WriteLine("2. System Analyst");
            Console.WriteLine("3. Developer ");
            Console.WriteLine("4. Accountant");
            Console.Write("Enter your choice: ");
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                Console.WriteLine(cki.KeyChar);
                if (cki.Key != ConsoleKey.NumPad1 && cki.Key != ConsoleKey.NumPad2
                    && cki.Key != ConsoleKey.NumPad3 && cki.Key != ConsoleKey.NumPad4)
                {
                    Console.Write("Wrong format, re-enter: ");
                }
                else
                {
                    if (cki.Key == ConsoleKey.NumPad1) return "Manager";
                    if (cki.Key == ConsoleKey.NumPad2) return "System Analyst";
                    if (cki.Key == ConsoleKey.NumPad3) return "Developer";
                    if (cki.Key == ConsoleKey.NumPad4) return "Accountant";
                }
            } while (cki.Key != ConsoleKey.Escape);
            return "";
        }

        public byte inputTenure()
        {
            Console.Write("Enter the tenure in years: ");
            String line = Console.ReadLine();
            byte tenure;
            while (!byte.TryParse(line, out tenure) || tenure < 0)
            {
                Console.Write("Wrong format, re-enter: ");
                line = Console.ReadLine();
            }
            return tenure;
        }

        public double getBonus()
        {
            if (tenure >= 3)
            {
                if (salary > 20000)
                {
                    bonus = salary * 0.09;
                }
                else if (salary > 14000 && salary <= 20000)
                {

                    bonus = salary * 0.05;
                }
                else
                {
                    bonus = salary * 0.02; ;
                }
            }
            return bonus;
        }

        public void inputData()
        {
            this.id = inputID();
            this.name = inputName();
            this.dob = inputDob();
            this.age = DateTime.Now.Year - this.dob.Year;
            this.gender = inpurGender();
            this.designation = inputDesignation();
            this.salary = 16729;
            this.tenure = inputTenure();
            this.bonus = getBonus();
            this.taxAmount = salary * 33 / 100;
            this.netSalary = salary - taxAmount;
        }

        public void showData()
        {
            Console.WriteLine("====================");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + (gender == 'M' ? "male" : "female"));
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Tenure: " + tenure);
            Console.WriteLine("Salary: " + salary + "$");
            Console.WriteLine("Tax Amount: " + taxAmount + "$");
            Console.WriteLine("Net Salary: " + netSalary + "$ is rounded off to: " + Math.Round(netSalary) + "$");
            Console.WriteLine("Bonus: " + bonus + "$");
            Console.WriteLine("====================");
        }
    }


}
