using DemoDataGridView.dal;
using DemoDataGridView.model;
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

namespace DemoDataGridView
{
    public partial class CustomerManagement : Form
    {
        CustomerDAO da;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            da = new CustomerDAO();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            datagridview.Columns.Clear();
            datagridview.Dock = DockStyle.Fill;
            bindingsource.DataSource = da.getCustomerList();
            datagridview.DataSource = bindingsource;
            datagridview.AllowUserToAddRows = true;
            datagridview.AllowUserToDeleteRows = true;
            datagridview.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bindingsource.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            bindingsource.MovePrevious();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            bindingsource.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            bindingsource.MoveLast();
        }

        private ArrayList getListFromDataGridView()
        {
            ArrayList list = new ArrayList();

            foreach (DataGridViewRow row in datagridview.Rows)
            {
                Customer customer = row.DataBoundItem as Customer;
                if (customer != null)
                {
                    list.Add(customer);
                    Console.WriteLine(customer.ToString());
                }
            }

            Console.WriteLine("End!");
            return list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            da.updateCustomerList();
            MessageBox.Show("Save done!");
            loadDataGridView();
        }
    }
}
