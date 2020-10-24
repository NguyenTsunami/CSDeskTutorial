using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPurchaseOrder
{
    class OrderItem
    {
        private Product product;
        private int quantity;
        private int amount;

        public int Quantity { get => quantity; set => quantity = value; }
        internal Product Product { get => product; set => product = value; }
        public int Amount { get => amount = product.Price * Quantity; }

        public OrderItem()
        {

        }

        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
