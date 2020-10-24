using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPurchaseOrder
{
    public partial class PurchaseOrder : Form
    {
        ArrayList orderList = new ArrayList();
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            loadOrderList();
        }

        private void loadOrderList()
        {
            listviewOrders.Items.Clear();

            //Load items
            int count = 0;
            int total = 0;
            foreach (OrderItem item in orderList)
            {
                String[] data =
                {
                    ++count + "",
                    item.Product.Name,
                    item.Product.Price + "",
                    item.Quantity + "",
                    item.Amount + ""
                };
                ListViewItem row = new ListViewItem(data);
                listviewOrders.Items.Add(row);
                total += item.Amount;
                Console.WriteLine(item.Amount);
            }

            //Load total txt
            txtTotal.Text = total + "";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string date = txtDate.Value.ToString("dd-MM-yyyy");
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if (String.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please input all fields!");
                return;
            }

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please input all fields!");
                return;
            }

            if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please input all fields!");
                return;
            }

            if (String.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please input all fields!");
                return;
            }

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please input all fields!");
                return;
            }

            if (orderList.Count == 0)
            {
                MessageBox.Show("empty orders!");
                return;
            }

            MessageBox.Show("Your order has been saved!");
            Application.Exit();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            ProductDetail order = new ProductDetail();
            if (order.ShowDialog() == DialogResult.OK)
            {
                Product product = (Product)order.CbxProduct.SelectedItem;
                int quantity = (int)order.NumQuantity.Value;
                OrderItem newitem = new OrderItem(product, quantity);

                bool added = false;
                foreach (OrderItem item in orderList)
                {
                    if (item.Product.Name.Equals(newitem.Product.Name))
                    {
                        added = true;
                        item.Quantity += newitem.Quantity;
                        break;
                    }
                }
                if (!added)
                {
                    orderList.Add(newitem);
                }

                loadOrderList();
            }
        }

        private void listviewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOrderList();
        }
    }
}
