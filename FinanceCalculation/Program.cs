using System;

namespace FinanceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Main2(args);
        }

        //BT2
        static void Main2(string[] args)
        {
            Worker worker = new Worker();
            worker.inputData();
            worker.displayData();
        }

        //BT1
        static void Main1(string[] args)
        {
            Expenditure exp = new Expenditure();
            exp.accceptDetails();
            exp.displayDetails();

            Expenditure rev = new Revenue();
            rev.accceptDetails();
            rev.displayDetails();
        }
    }
}
