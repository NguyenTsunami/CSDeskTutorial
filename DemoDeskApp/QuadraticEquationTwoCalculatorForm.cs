using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDeskApp
{
    public partial class QuadraticEquationTwoCalculatorForm : Form
    {
        public QuadraticEquationTwoCalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Get data
            double a, b, c;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                if (a > 100 || a < -100 || b > 100 || b < -100 || c > 100 || c < -100)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                txtRes.Text = "Nhập sai dữ liệu!\r\nHãy nhập các số thực trong khoảng [-100;100]!";
                return;
            }

            //
            double d = b * b - 4 * a * c;
            double x1, x2;
            String res = "";

            //Calculate
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        res = res + "Phương trình có vô số nghiệm!\r\n";
                    }
                    else
                    {
                        res = res + "Phương trình vô nghiệm!\r\n";
                    }
                }
                else
                {
                    x1 = -c / b;
                    res = res + "Phương trình có 1 nghiệm duy nhất:\r\n";
                    res = res + "\tx = " + x1 + "\r\n";
                }
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                res = res + "Phương trình có 2 nghiệm phân biệt:\r\n";
                res = res + "\tx1 = " + x1 + "\r\n";
                res = res + "\tx2 = " + x2 + "\r\n";
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                res = res + "Phương trình có 1 nghiệm kép:\r\n";
                res = res + "\tx = " + x1 + "\r\n";
            }
            else if (d < 0)
            {
                res = res + "Phương trình vô nghiệm!\r\n";
            }

            txtRes.Text = res;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
