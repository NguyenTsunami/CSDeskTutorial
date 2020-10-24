using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePurchaseOrder
{
    class Vehicle
    {
        private String name;
        private String manufactorier;
        private int yearMaker;
        private int engineCapacity;
        private double price;
        private int wheeler;

        public string Manufactorier { get => manufactorier; set => manufactorier = value; }
        public int YearMaker { get => yearMaker; set => yearMaker = value; }
        public int EngineCapacity { get => engineCapacity; set => engineCapacity = value; }
        public double Price { get => price; set => price = value; }
        public int Wheeler { get => wheeler; set => wheeler = value; }
        public string Name { get => name; set => name = value; }

        public Vehicle()
        {

        }

        public Vehicle(string name, string manufactorier, int yearMaker, int engineCapacity, double price, int wheeler)
        {
            this.name = name;
            this.manufactorier = manufactorier;
            this.yearMaker = yearMaker;
            this.engineCapacity = engineCapacity;
            this.price = price;
            this.wheeler = wheeler;
        }
    }
}
