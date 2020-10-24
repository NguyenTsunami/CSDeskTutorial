using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilmManagement
{
    class Film
    {
        private String sName;
        private double dLength;
        private String sProducer;
        private double dPrice;
        private double dNumber;
        private double dTotal;

        public string SName
        {
            get => sName;
            set
            {
                if (value.Length > 255)
                {
                    throw new Exception("Name can not more than 255 characters!");
                }
                else
                {
                    sName = value;
                }
            }
        }
        public double DLength
        {
            get => dLength;
            set
            {
                if (value < 30 || value > 150)
                {
                    throw new Exception("Length must be in range [30-150]!");
                }
                else
                {
                    dLength = value;
                }
            }
        }
        public string SProducer { get => sProducer; set => sProducer = value; }
        public double DPrice { get => dPrice; set => dPrice = value; }
        public double DNumber
        {
            get => dNumber;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Number must be in range [0-100]!");
                }
                else
                {
                    dNumber = value;
                }
            }
        }
        public double DTotal
        {
            get
            {
                dTotal = dPrice * dNumber;
                return dTotal;
            }
        }

        public Film()
        {
            try
            {
                this.SProducer = "FaFilm";
                this.DPrice = 8000;
                this.DNumber = 10;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return sName + " | " + dLength + "' | " + sProducer + " | " + dPrice + "$ | " + dNumber + " | " + DTotal + "$";
        }

        public void inputData()
        {
            //Name
            do
            {
                try
                {
                    Console.Write("Enter name: ");
                    this.SName = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Re-enter please!");
                }
            }
            while (true);
            //Length
            do
            {
                try
                {
                    Console.Write("Enter length (in minutes): ");
                    this.DLength = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Re-enter please!");
                }
            }
            while (true);
            //Producer
            do
            {
                try
                {
                    Console.Write("Enter producer: ");
                    this.SProducer = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Re-enter please!");
                }
            }
            while (true);
            //Price
            do
            {
                try
                {
                    Console.Write("Enter price: ");
                    this.DPrice = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Re-enter please!");
                }
            }
            while (true);
            //Number
            do
            {
                try
                {
                    Console.Write("Enter number: ");
                    this.DNumber = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Re-enter please!");
                }
            }
            while (true);
        }
    }
}
