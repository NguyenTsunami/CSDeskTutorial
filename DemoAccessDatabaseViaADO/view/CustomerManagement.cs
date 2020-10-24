using DemoAccessDatabaseViaADO.dal;
using DemoAccessDatabaseViaADO.model;
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

namespace DemoAccessDatabaseViaADO
{
    public partial class CustomerManagement : Form
    {
        int actionid = 0; // 0-add; 1-edit
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            //loas list
            loadCustomerList();

            //setting max length of text field
            txtName.Mask = new string('a', 50);
            txtAddress.Mask = new string('a', 50);
            txtCity.Mask = new string('a', 50);
            txtCountry.Mask = new string('a', 50);

            //setting button
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnExit.Enabled = true;
            listviewCustomers.Enabled = true;

            //setting accessible of groupbox
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtPhone.Enabled = false;
            txtZipcode.Enabled = false;
        }

        private void loadCustomerList()
        {
            listviewCustomers.Items.Clear();
            ArrayList list = new CustomerDAO().getCustomerList();
            foreach (Customer c in list)
            {

                String[] data =
                {
                    c.Name,
                    c.Address,
                    c.City,
                    c.Country,
                    c.Phone,
                    c.Zipcode,
                    c.Id.ToString()
                };
                ListViewItem row = new ListViewItem(data);
                listviewCustomers.Items.Add(row);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listviewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //edit infor in groupbox
            if (listviewCustomers.SelectedItems.Count > 0)
            {
                txtName.Text = listviewCustomers.SelectedItems[0].SubItems[0].Text;
                txtAddress.Text = listviewCustomers.SelectedItems[0].SubItems[1].Text;
                txtCity.Text = listviewCustomers.SelectedItems[0].SubItems[2].Text;
                txtCountry.Text = listviewCustomers.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = listviewCustomers.SelectedItems[0].SubItems[4].Text;
                txtZipcode.Text = listviewCustomers.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                txtName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtCountry.Text = "";
                txtPhone.Text = "";
                txtZipcode.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //setting button
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnExit.Enabled = true;
            listviewCustomers.Enabled = false;

            //setting accessible of groupbox
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            txtCountry.Enabled = true;
            txtPhone.Enabled = true;
            txtZipcode.Enabled = true;

            //clear selection in list view
            listviewCustomers.SelectedIndices.Clear();

            //set action id
            actionid = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //setting button
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnExit.Enabled = true;
            listviewCustomers.Enabled = true;

            //setting accessible of groupbox
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtPhone.Enabled = false;
            txtZipcode.Enabled = false;

            //clear selection in list view
            listviewCustomers.SelectedIndices.Clear();

            //setting data in groupbox
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtZipcode.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //check ability to edit
            if (listviewCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a Customer in list!");
                return;
            }

            //setting button
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnExit.Enabled = true;
            listviewCustomers.Enabled = false;

            //setting accessible of groupbox
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            txtCountry.Enabled = true;
            txtPhone.Enabled = true;
            txtZipcode.Enabled = true;

            //set action id
            actionid = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get param
            String name = txtName.Text;
            String address = txtAddress.Text;
            String city = txtCity.Text;
            String country = txtCountry.Text;
            String phone = txtPhone.Text;
            String zipcode = txtZipcode.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("Please fill name!");
                return;
            }
            if (address == string.Empty)
            {
                MessageBox.Show("Please fill address!");
                return;
            }
            if (city == string.Empty)
            {
                MessageBox.Show("Please fill city!");
                return;
            }
            if (country == string.Empty)
            {
                MessageBox.Show("Please fill country!");
                return;
            }
            if (!txtPhone.MaskFull)
            {
                MessageBox.Show("Please fill phone!");
                return;
            }
            if (!txtZipcode.MaskFull)
            {
                MessageBox.Show("Please fill zipcode!");
                return;
            }
            Customer customer = new Customer(name, address, city, country, phone, zipcode);

            //update database
            CustomerDAO da = new CustomerDAO();
            if (actionid == 0)
            {
                da.addCustomer(customer);
                MessageBox.Show("Add done!");
            }
            else if (actionid == 1)
            {
                int id = Convert.ToInt32(listviewCustomers.SelectedItems[0].SubItems[6].Text);
                da.editCustomer(customer, id);
                MessageBox.Show("Edit done!");
            }

            //load listview
            loadCustomerList();

            //setting button
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnExit.Enabled = true;
            listviewCustomers.Enabled = true;

            //setting accessible of groupbox
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtPhone.Enabled = false;
            txtZipcode.Enabled = false;

            //clear selection in list view
            listviewCustomers.SelectedIndices.Clear();

            //setting data in groupbox
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtZipcode.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check ability to delete
            if (listviewCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a Customer in list!");
                return;
            }

            //get id
            int id = Convert.ToInt32(listviewCustomers.SelectedItems[0].SubItems[6].Text);

            //confirm to delete
            string message = "Do you want to delete this Customer?";
            string title = "Confirm Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //delete
                CustomerDAO da = new CustomerDAO();
                da.deleteCustomer(id);

                //notify
                MessageBox.Show("Delete done!");

                //load listview
                loadCustomerList();

                //clear selection in list view
                listviewCustomers.SelectedIndices.Clear();

                //setting data in groupbox
                txtName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtCountry.Text = "";
                txtPhone.Text = "";
                txtZipcode.Text = "";
            }
            else
            {
                return;
            }
        }
    }
}
