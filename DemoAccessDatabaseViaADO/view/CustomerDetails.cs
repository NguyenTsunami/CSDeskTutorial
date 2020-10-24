using DemoAccessDatabaseViaADO.dal;
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

namespace DemoAccessDatabaseViaADO.view
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            //load bindingsource
            CustomerDAO da = new CustomerDAO();
            ArrayList customerList = da.getCustomerList();
            binderCustomer.DataSource = customerList;

            //setting components's enable
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnExit.Enabled = true;
            txtName.Enabled = false;
            txtDob.Enabled = false;
            txtAddress.Enabled = false;
            radioFemale.Enabled = false;
            radioMale.Enabled = false;

            //setting data display
            txtName.DataBindings.Add(new Binding("Text", binderCustomer, "name"));
            txtDob.DataBindings.Add(new Binding("Text", binderCustomer, "dob"));
            txtAddress.DataBindings.Add(new Binding("Text", binderCustomer, "address"));

            var maleBinding = new Binding("Checked", binderCustomer, "gender");
            maleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "male";
            maleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "male" : "female";
            radioMale.DataBindings.Add(maleBinding);

            //radioMale.CheckedChanged += (s, args) => radioFemale.Checked = !radioMale.Checked; //not work for all

            var femaleBinding = new Binding("Checked", binderCustomer, "gender");
            femaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "female";
            femaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "female" : "male";
            radioFemale.DataBindings.Add(femaleBinding);

        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            binderCustomer.MoveLast();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            binderCustomer.MoveNext();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            binderCustomer.MovePrevious();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            binderCustomer.MoveFirst();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
