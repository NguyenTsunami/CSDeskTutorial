using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceCalculation
{
    class Revenue : Expenditure
    {
        private double totalIncome { get; set; }
        private double netProfit { get; set; }
        public Revenue() : base()
        {

        }

        public override void accceptDetails()
        {
            base.accceptDetails();
            Console.Write("Enter income: ");
            totalIncome = Convert.ToDouble(Console.ReadLine());
            netProfit = totalIncome - totalExpenses;
        }

        public override void displayDetails()
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
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-30}{1,-10}", "Total Income", totalIncome));
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-30}{1,-10}", "Net Profit", netProfit));
            Console.WriteLine(new String('~', 60));
        }
    }
}
