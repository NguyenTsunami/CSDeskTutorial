using System;
using System.Dynamic;

namespace Demo
{
    /*
     *
    Phím tắt:
        F5 – Ctrl F5 – Debug
        F11 - Run debug
        F12 – See implementation
        Ctrl K + Ctrl D – Format Code
        Ctrl K + Ctrl C – Comment Code 
        Ctrl K + Ctril U – Uncomment Code
        Ctrl R + Ctrl E - Auto gen get, set of prop

    Cách sử dụng snippet: Gõ ra rồi Tab là xong
        ctor – Tạo contrucstor cho class
        prop – Tạo properties – Gõ xong nhớ Tab Tab
        cw – Console.WriteLine() – Cho mấy bạn hay code Console
        for/forr – Tự tạo hàm for
        svm - Tạo hàm main
    *
    */

    class Program
    {
        static void Main(string[] args)
        {
            Main10(args);
        }

        //Demo Polymorphism
        static void Main10(string[] args)
        {
            Animal a = new Cat("Meow", 6, 10);
            a.move();
            //a.haughty();
            a.sleep();
        }

        //Demo Event
        static void Main9(string[] args)
        {
            Demo_Eventation demo = new Demo_Eventation();
            demo.runEvent();
        }

        //Demo Calculate Tax From Many Country Via Delegate
        static void Main8(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Salary: " + person.salary);
            Console.WriteLine("Country: " + person.country);
            Console.WriteLine("Tax: " + person.getTax());
        }

        //Demo Delegate
        static void Main7(string[] args)
        {
            Calculator.Calculation cal = Calculator.add;

            Console.WriteLine("5 + 6 = " + cal(5, 6));

            cal = Calculator.sub;

            Console.WriteLine("5 - 6 = " + cal(5, 6));

            cal = Calculator.mul;

            Console.WriteLine("5 x 6 = " + cal(5, 6));
        }

        //Demo Input Double in [0-10]
        static void Main6(string[] args)
        {
            double score = -1;
            do
            {
                try
                {
                    Console.Write("Enter score: ");
                    score = Convert.ToDouble(Console.ReadLine());
                    if (score < 0 || score > 10)
                    {
                        throw new Exception("Score must in [0-10] only!");
                    }
                }
                catch (FormatException e1)
                {
                    score = -1;
                    Console.WriteLine("Wrong format!");
                    Console.WriteLine(e1.Message.ToString());
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message.ToString());
                }
            } while (score < 0 || score > 10);

            Console.WriteLine("Score: " + score);
        }

        //Demo Exception
        static void Main5(string[] args)
        {
            int a, b, c;
            try
            {
                Console.Write("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Wrong format!");
                Console.WriteLine(e1.Message.ToString());
            }
            catch (OverflowException e2)
            {
                Console.WriteLine("Too big value!");
                Console.WriteLine(e2.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Finish program!");
            }
        }

        //Hello World
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        //Demo Static Function
        static void Main2(string[] args)
        {
            Console.WriteLine("Nhap Fahrenheit: ");
            double fa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(convertFahrenheitToCelcius(fa));

            drawMultiTenTable();

            Console.WriteLine(calEpowX(3));
        }

        //Demo Normal Class - Person
        static void Main3(string[] args)
        {
            Person p = new Person("Tsunami", 20);
            p.showInfo();
        }

        //Demo Complex Class - Employee
        static void Main4(string[] args)
        {
            Employee emp = new Employee();
            emp.inputData();
            emp.showData();
        }

        //---------------------------------- Static Function -------------------------------------

        static double convertFahrenheitToCelcius(double fa)
        {
            return (double)(fa - 32) * 5 / 9;
        }

        static void drawMultiTenTable()
        {
            Console.WriteLine(String.Format("{0,-10}\t{1,-10}\t{2,-10}\t{3,-10}",
                "N", "10xN", "100xN", "1000xN"));
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("{0,-10}\t{1,-10}\t{2,-10}\t{3,-10}",
                i, i * 10, i * 100, i * 1000));
            }
        }

        static double calFatorial(int x)
        {
            double res = 1;
            if (x == 0 || x == 1)
            {
                return res;
            }
            for (int i = 2; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }

        static double calApowB(double a, int b)
        {
            double res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= a;
            }
            return res;
        }
        static double calEpowX(double x)
        {
            double res = 1;
            double temp = 0;
            int i = 0;
            while (temp != res)
            {
                res = temp;
                temp = temp + calApowB(x, i) / calFatorial(i);
                i++;
            }
            return res;
        }
    }
}
