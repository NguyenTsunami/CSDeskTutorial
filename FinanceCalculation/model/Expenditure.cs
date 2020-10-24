using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceCalculation
{
    class Expenditure
    {
        public string[] type = { "Maintainence", "Salary Paid", "Miscellaneous" };
        public double[] amount { get; set; }
        public double totalExpenses { get; set; }
        public Expenditure()
        {
            amount = new double[type.Length];
            totalExpenses = 0;
        }

        public virtual void accceptDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the expenditure for the following heads: ");
            for (int i = 0; i < type.Length; i++)
            {
                Console.Write(type[i] + ": ");
                double value = Convert.ToDouble(Console.ReadLine());
                amount[i] = value;
                totalExpenses += amount[i];
            }
            
        }

        public virtual void displayDetails()
        {
            Console.WriteLine();
            Console.WriteLine(new String('~', 60));

            Console.WriteLine(String.Format("{0,-30}{1,-10}", "Expenditure Head", "Amount ($)"));
            Console.WriteLine(new String('-', 40));
            for (int i = 0; i < type.Length; i++)
            {
                Console.WriteLine(String.Format("{0,-30}{1,-10}", type[i], amount[i]));
            }
            Console.WriteLine(new String('-', 40));
            Console.WriteLine(String.Format("{0,-30}{1,-10}", "Total Expenditure", totalExpenses));

            Console.WriteLine(new String('~', 60));
        }

    }
}
