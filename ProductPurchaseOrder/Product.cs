using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPurchaseOrder
{
    class Product
    {
        private String name;
        private int price;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Product()
        {

        }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
