using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceCalculation
{
    class Appraisal
    {
        public double bonus { get; set; }

        public Appraisal(String designation, int tenure, double salary)
        {
            if (designation.Equals("Manager"))
            {
                if (tenure < 5)
                {
                    bonus = salary * 1.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation.Equals("Engineer"))
            {
                if (tenure < 5)
                {
                    bonus = salary;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation.Equals("Technician"))
            {
                if (tenure < 3)
                {
                    bonus = salary * 0.25;
                }
                else if (tenure < 5)
                {
                    bonus = salary * 0.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
        }
    }
}
