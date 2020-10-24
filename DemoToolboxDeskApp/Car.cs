using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoToolboxDeskApp
{
    class Car
    {
        private String model;
        private String engine;
        private double mileage;
        private double mxspeed;
        private String img;

        public string Model { get => model; set => model = value; }
        public string Engine { get => engine; set => engine = value; }
        public double Mileage { get => mileage; set => mileage = value; }
        public double Mxspeed { get => mxspeed; set => mxspeed = value; }
        public string Img { get => img; set => img = value; }

        public Car()
        {

        }

        public Car(string model, string engine, double mileage, double mxspeed, string img)
        {
            Model = model;
            Engine = engine;
            Mileage = mileage;
            Mxspeed = mxspeed;
            Img = img;
        }


    }
}
