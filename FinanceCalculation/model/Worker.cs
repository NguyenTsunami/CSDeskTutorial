using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceCalculation
{
    class Worker
    {
        private string name { get; set; }
        private int id { get; set; }
        private string designation { get; set; }
        private double salary { get; set; }
        private int tenure { get; set; }
        private double income { get; set; }

        public Worker()
        {

        }

        public void inputData()
        {
            Console.WriteLine();
            Console.WriteLine(new String('~', 100));

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Select designation (1-3): ");
            Console.WriteLine("1 - Manager");
            Console.WriteLine("2 - Engineer");
            Console.WriteLine("3 - Techinician");
            Console.Write("Enter choice: ");
            ConsoleKeyInfo choice = Console.ReadKey(true);
            Console.WriteLine(choice.KeyChar);
            designation = (choice.Key == ConsoleKey.D1 ? "Manager" : (choice.Key == ConsoleKey.D2 ? "Engineer" : "Technician"));
            salary = (choice.Key == ConsoleKey.D1 ? 2000 : (choice.Key == ConsoleKey.D2 ? 1500 : 1000));
            Console.WriteLine();
            Console.Write("Enter tenure: ");
            tenure = Convert.ToInt32(Console.ReadLine());
            income = salary + new Appraisal(designation, tenure, salary).bonus;

            Console.WriteLine(new String('~', 100));
            Console.WriteLine();
        }

        public void displayData()
        {
            Console.WriteLine();
            Console.WriteLine(new String('~', 100));

            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + new Appraisal(designation, tenure, salary).bonus);
            Console.WriteLine("Total income: " + income);

            Console.WriteLine(new String('~', 100));
            Console.WriteLine();
        }
    }
}
